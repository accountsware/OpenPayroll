using System.Collections.Generic;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Core
{
	public class CityCore : BaseCore
	{
        public CityCore()
        {
            ObjectName = "Cities";
        }

        public void Save(ICityModel businessModel) 
        {
			using (Repository = new CityRepository())
			{
				Message = SaveSuccessMessage;
				Repository.Save(businessModel);
			}
        }

		public void Update(ICityModel businessModel) 
        {
			using (Repository = new CityRepository())
			{
				Message = UpdateSuccessMessage;
				Repository.Update(businessModel);
			}
        }

        public void Delete(int id)
        {
			using (Repository = new CityRepository())
			{
				Message = DeleteSuccessMessage;
				Repository.Delete(id);
			}
        }
		
		public IEnumerable<T> Get<T>(params IListParameter[] parameter)
        {
			using (Repository = new CityRepository())
			{
				var data = Repository.Get(parameter);
				return data as IEnumerable<T>;
			}
        }

		public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
        {
			using (Repository = new CityRepository())
			{
				var data = Repository.Get(start, limit, sort, dir, out totalCount, parameter);
				return data as IEnumerable<T>;
			}
        }

    }

}
