using System;
using System.Collections.Generic;
using System.Linq;
using K.Common.Data;
using K.Common.Patterns;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model;

namespace K.HR.Payroll.DataRepository
{
    public class CityRepository : BaseRepository
    {
        public CityRepository()
        {
            ObjectName = "Cities";
        }

        public override int Save(IBaseModel businessModel)
        {
            var model = businessModel as ICityModel;
            if (model == null)
                throw new Exception(MessageModelNull);
            var entity = PopulateModelToNewEntity(model);
            Entities.AddToCities(entity);
            return Entities.SaveChanges();
        }

        private static City PopulateModelToNewEntity(ICityModel model)
        {
            return new City
            {
                Id = model.Id,
                RowVersion = model.RowVersion,
                RowStatus = model.RowStatus,
                CityName = model.CityName,
                CreatedBy = model.CreatedBy,
                CreatedDate = model.CreatedDate,
                ModifiedBy = model.ModifiedBy,
                ModifiedDate = model.ModifiedDate,
            };
        }

        public override int Update(IBaseModel businessModel)
        {
            var model = businessModel as ICityModel;
            if (model == null)
                throw new Exception(MessageModelNull);
            var query = (from d in Entities.Cities where d.Id == model.Id select d).FirstOrDefault();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            PopulateModelToNewEntity(query, model);
            return Entities.SaveChanges();
        }

        private static void PopulateModelToNewEntity(City query, ICityModel model)
        {
            query.Id = model.Id;
            query.RowVersion = model.RowVersion;
            query.RowStatus = model.RowStatus;
            query.CityName = model.CityName;
            query.CreatedBy = model.CreatedBy;
            query.CreatedDate = model.CreatedDate;
            query.ModifiedBy = model.ModifiedBy;
            query.ModifiedDate = model.ModifiedDate;
        }

        public override int Delete(int id)
        {
            var query = (from d in Entities.Cities where d.Id == id select d).FirstOrDefault();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            Entities.Cities.DeleteObject(query);
            return Entities.SaveChanges();
        }


        private static CityModel PopulateEntityToNewModel(City item)
        {
            return new CityModel
            {
                Id = item.Id,
                RowVersion = item.RowVersion,
                RowStatus = item.RowStatus,
                CityName = item.CityName,
                CreatedBy = item.CreatedBy,
                CreatedDate = item.CreatedDate,
                ModifiedBy = item.ModifiedBy,
                ModifiedDate = item.ModifiedDate,
            };
        }

        public override IEnumerable<IBaseModel> Get(params WhereTerm[] parameter)
        {
            var whereterm = GetQueryParameterLinq(parameter);
            var query = (from a in Entities.Cities select a).Where(whereterm, ListValue.ToArray()).ToList();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            return query.Select(PopulateEntityToNewModel).Cast<ICityModel>().ToList();
        }

        public override IEnumerable<IBaseModel> Get(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
        {
            ValidateSorting(ref sort, ref dir);
            var whereterm = GetQueryParameterLinq(parameter);
            var query = (from a in Entities.Cities select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir).Skip(start).Take(limit).ToList();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            var tquery = (from a in Entities.Positions select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir);
            totalCount = tquery.Count();
            return query.Select(PopulateEntityToNewModel).Cast<ICityModel>().ToList();
        }

    }

}
