using System;
using System.Collections.Generic;
using K.Common.Interfaces;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
	public class PayrollGroupCore : PayrollBaseCore
	{
		public PayrollGroupCore()
		{
			ObjectName = "PayrollGroup";
		}

		public void Save<T>(T businessModel) where T : IPayrollGroupModel
		{
            using (Entities = new kk_sp_payrollEntities())
            {
                OpenConnection();
                using (var transaction = Entities.Connection.BeginTransaction(TRANSACTION_ISOLATION))
                {
                    var payrollGroupRepository = new PayrollGroupRepository(Entities);
                    payrollGroupRepository.Save(businessModel);

                    var itemRepository = new PayrollItemRepository(Entities);
                    foreach (var payrollItemModel in businessModel.ListPayrollItemModel)
                    {
                        payrollItemModel.PayrolGroupId = businessModel.Id;
                        itemRepository.Save(payrollItemModel);
                    }
                    transaction.Commit();
                    CloseConnection();
                    payrollGroupRepository.Dispose();
                    itemRepository.Dispose();
                }
            }
		}

		public void Update<T>(T businessModel) where T : IPayrollGroupModel
		{
			using (Repository = new PayrollGroupRepository())
			{
				Message = UpdateSuccessMessage;
				Repository.Update(businessModel);
			}
		}

		public void Delete(int id)
		{
			using (Repository = new PayrollGroupRepository())
			{
				Message = DeleteSuccessMessage;
				Repository.Delete(id);
			}
		}


		public IEnumerable<T> Get<T>(params IListParameter[] parameter) where T: IPayrollGroupModel
		{
			using (Repository = new PayrollGroupRepository())
			{
				var data = Repository.Get<T>(parameter);
				return data;
			}
		}

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			using (Repository = new PayrollGroupRepository())
			{
				var data = Repository.Get<IPayrollGroupModel>(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
		}

        public static IEnumerable<String> GetTypeItem()
        {
            return new List<String> { "EARNINGS", "DEDUCTIONS" };
        }

        public static IEnumerable<String> GetUnitTypeItem()
        {
            return new List<String> { "BASE-ON-VALUE", "PERCENTAGE-VALUE", "UNIT-VALUE" }; 
        }

	}

}
