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
	public class PositionModuleCore : PayrollModuleCore
	{

		public PositionModuleCore()
		{
			ObjectName = "Employee Position";
		}

		public int Save(IPositionModel businessModel)
		{
			using (Repository = new PositionRepository())
			{
				Message = SaveSuccessMessage;
				return Repository.Save(businessModel);
			}
		}

		public int Update(IPositionModel businessModel)
		{
			using (Repository = new PositionRepository())
			{
				Message = UpdateSuccessMessage;
				return Repository.Update(businessModel);
			}
		}

		public int Delete(int id)
		{
			using (Repository = new PositionRepository())
			{
				Message = DeleteSuccessMessage;
				return Repository.Delete(id);
			}
		}


		public IEnumerable<T> Get<T>(params IListParameter[] parameter)
		{
			using (Repository = new PositionRepository())
			{
				var data = Repository.Get(parameter);
				return data as IEnumerable<T>;
			}
		}

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			using (Repository = new PositionRepository())
			{
				var data = Repository.Get(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
		}
	}
}
