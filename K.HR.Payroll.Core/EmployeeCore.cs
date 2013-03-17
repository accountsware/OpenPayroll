using System;
using System.Collections.Generic;
using K.Common;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
	public class EmployeeCore : BaseCore
	{

		public EmployeeCore()
		{
			ObjectName = "Employee";
		}

		public void Save<T>(T businessModel) where T : IEmployeeModel
		{
			using (Repository = new EmployeeRepository())
			{
				Message = SaveSuccessMessage;
				Repository.Save(businessModel);
			}
		}

		public void Update<T>(T businessModel) where T : IEmployeeModel
		{
			using (Repository = new EmployeeRepository())
			{
				Message = UpdateSuccessMessage;
				Repository.Update(businessModel);
			}
		}

		public int Delete(int id)
		{
			using (Repository = new EmployeeRepository())
			{
				Message = DeleteSuccessMessage;
				return Repository.Delete(id);
			}
		}

		public IEnumerable<T> Get<T>(params IListParameter[] parameter)
		{
			using (Repository = new EmployeeRepository())
			{
				var data = Repository.Get(parameter);
				return data as IEnumerable<T>;

			}
		}

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			using (Repository = new EmployeeRepository())
			{
				var data = Repository.Get(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;

			}
		}


	}
}
