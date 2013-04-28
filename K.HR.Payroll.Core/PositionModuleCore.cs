using System.Collections.Generic;
using K.Common.Interfaces;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
	public class PositionModuleCore : PayrollBaseCore
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


		public IEnumerable<T> Get<T>(params IListParameter[] parameter) where  T : IPositionModel
		{
			using (Repository = new PositionRepository())
			{
				var data = Repository.Get<T>(parameter);
				return data;
			}
		}

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			using (Repository = new PositionRepository())
			{
				var data = Repository.Get<IPositionModel>(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
		}
	}
}
