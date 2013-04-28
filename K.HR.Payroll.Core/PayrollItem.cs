using System.Collections.Generic;
using K.Common.Interfaces;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
    public class PayrollItemModuleCore : PayrollBaseCore
    {
        public PayrollItemModuleCore()
        {
            ObjectName = "PayrollItem";
        }

        public void Save(IPayrollItemModel businessModel) 
        {
			using (Repository = new PayrollItemRepository())
			{
				Message = SaveSuccessMessage;
				Repository.Save(businessModel);
			}
        }

		public void Update(IPayrollItemModel businessModel)
        {
			using (Repository = new PayrollItemRepository())
			{
				Message = UpdateSuccessMessage;
				Repository.Update(businessModel);
			}
        }

		public void Delete(int id)
        {
			using (Repository = new PayrollItemRepository())
			{
				Message = DeleteSuccessMessage;
				Repository.Delete(id);
			}
        }

		public IEnumerable<T> Get<T>(params IListParameter[] parameter) where T : IPayrollItemModel
        {
			using (Repository = new PayrollItemRepository())
			{
				var data = Repository.Get<T>(parameter);
				return data;
			}
        }

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
        {
			using (Repository = new PayrollItemRepository())
			{
				var data = Repository.Get<IPayrollItemModel>(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
        }

    }

}
