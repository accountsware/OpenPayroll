using System;
using System.Collections.Generic;
using K.Common;
using K.Common.Data;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
	public class PayrollGroupCore : BaseCore
	{
		public PayrollGroupCore()
		{
			ObjectName = "PayrollGroup";
		}

		public void Save<T>(T businessModel) where T : IPayrollGroupModel
		{
			using (Repository = new PayrollGroupRepository())
			{
				Message = SaveSuccessMessage;
				Repository.Save(businessModel);
			}
		}

		public void Save<T>(T businessModel, List<T> listDetail) where T : IPayrollGroupModel
		{
			using (Entities = new kk_sp_payrollEntities())
			{
				OpenConnection();
				using (var transaction = Entities.Connection.BeginTransaction(TRANSACTION_ISOLATION))
				{
					// TODO TRANSACTION LOGIC
					// var repoheadre = neww
					// var repodetail = new
					transaction.Commit();
					CloseConnection();
					//Message = "Goods Receipt No " + goodsReceiptModel.GRNo + " has been Save Succesfully";
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


		public IEnumerable<T> Get<T>(params IListParameter[] parameter)
		{
			using (Repository = new PayrollGroupRepository())
			{
				var data = Repository.Get(parameter);
				return data as IEnumerable<T>;
			}
		}

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			using (Repository = new PayrollGroupRepository())
			{
				var data = Repository.Get(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
		}

	}

}
