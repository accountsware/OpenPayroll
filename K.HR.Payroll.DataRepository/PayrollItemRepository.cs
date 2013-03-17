using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.Data;
using K.Common.Patterns;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.DataRepository
{
    public class PayrollItemRepository : BaseRepository
    {
        public PayrollItemRepository()
        {
            ObjectName = "PayrollItem";
        }

        public override int Save(IBaseModel businessModel)
        {
            var model = businessModel as IPayrollItemModel;
            if (model == null)
                throw new Exception(MessageModelNull);
            var entity = PopulateModelToNewEntity(model);
            Entities.AddToPayrollItems(entity);
            return Entities.SaveChanges();
        }

        private static PayrollItem PopulateModelToNewEntity(IPayrollItemModel model)
        {
            return new PayrollItem
            {
                Id = model.Id,
                RowVersion = model.RowVersion,
                RowStatus = model.RowStatus,
                PayrolGroupId = model.PayrolGroupId,
                Name = model.Name,
                ItemType = model.ItemType,
                Type = model.Type,
                Value = model.Value,
                Unit = model.Unit,
                Description = model.Description,
                CreatedBy = model.CreatedBy,
                CreatedDate = model.CreatedDate,
                ModifiedBy = model.ModifiedBy,
                ModifiedDate = model.ModifiedDate,
            };
        }

        public override int Update(IBaseModel businessModel)
        {
            var model = businessModel as IPayrollItemModel;
            if (model == null)
                throw new Exception(MessageModelNull);
            var query = (from d in Entities.PayrollItems where d.Id == model.Id select d).FirstOrDefault();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            PopulateModelToNewEntity(query, model);
            return Entities.SaveChanges();
        }

        private void PopulateModelToNewEntity(PayrollItem query, IPayrollItemModel model)
        {
            query.Id = model.Id;
            query.RowVersion = model.RowVersion;
            query.RowStatus = model.RowStatus;
            query.PayrolGroupId = model.PayrolGroupId;
            query.Name = model.Name;
            query.ItemType = model.ItemType;
            query.Type = model.Type;
            query.Value = model.Value;
            query.Unit = model.Unit;
            query.Description = model.Description;
            query.CreatedBy = model.CreatedBy;
            query.CreatedDate = model.CreatedDate;
            query.ModifiedBy = model.ModifiedBy;
            query.ModifiedDate = model.ModifiedDate;
        }

        public override int Delete(int id)
        {
            var query = (from d in Entities.PayrollItems where d.Id == id select d).FirstOrDefault();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            Entities.PayrollItems.DeleteObject(query);
            return Entities.SaveChanges();
        }

        private static PayrollItemModel PopulateEntityToNewModel(PayrollItem item)
        {
            return new PayrollItemModel
            {
                Id = item.Id,
                RowVersion = item.RowVersion,
                RowStatus = item.RowStatus,
                PayrolGroupId = item.PayrolGroupId,
                Name = item.Name,
                ItemType = item.ItemType,
                Type = item.Type,
                Value = item.Value,
                Unit = item.Unit,
                Description = item.Description,
                CreatedBy = item.CreatedBy,
                CreatedDate = item.CreatedDate,
                ModifiedBy = item.ModifiedBy,
                ModifiedDate = item.ModifiedDate,
            };
        }

		public override IEnumerable<IBaseModel> Get(params IListParameter[] parameter)
        {
            var whereterm = GetQueryParameterLinq(parameter);
            var query = (from a in Entities.PayrollItems select a).Where(whereterm, ListValue.ToArray()).ToList();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            return query.Select(PopulateEntityToNewModel).Cast<IPayrollItemModel>().ToList();
        }

        public override IEnumerable<IBaseModel> Get(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
        {
            ValidateSorting(ref sort, ref dir);
            var whereterm = GetQueryParameterLinq(parameter);
            var query = (from a in Entities.PayrollItems select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir).Skip(start).Take(limit).ToList();
            if (query == null)
                throw new Exception(MessageEntityNotFound);
            var tquery = (from a in Entities.Positions select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir);
            totalCount = tquery.Count();
            return query.Select(PopulateEntityToNewModel).Cast<IPayrollItemModel>().ToList();
        }

    }

}
