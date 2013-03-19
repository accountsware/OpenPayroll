using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
    public class PayrollItemModuleCore : PayrollModuleCore
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

		public IEnumerable<T> Get<T>(params IListParameter[] parameter)
        {
			using (Repository = new PayrollItemRepository())
			{
				var data = Repository.Get(parameter);
				return data as IEnumerable<T>;
			}
        }

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
        {
			using (Repository = new PayrollItemRepository())
			{
				var data = Repository.Get(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
        }

    }

}
