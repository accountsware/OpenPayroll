using System;
using System.Collections.Generic;
using System.Linq;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.DataRepository
{
	public class PayrollGroupRepository : BaseRepository
	{
		public PayrollGroupRepository()
		{
			ObjectName = "Payroll Group";
		}

		public override int Save(IBaseModel businessModel)
		{
			var model = businessModel as IPayrollGroupModel;
			if (model == null)
				throw new Exception(MessageModelNull);
			var entity = PopulateModelToNewEntity(model);
			Entities.AddToPayrollGroups(entity);
			return Entities.SaveChanges();
		}

		private static PayrollGroup PopulateModelToNewEntity(IPayrollGroupModel model)
		{
			return new PayrollGroup
			{
				Id = model.Id,
				RowVersion = model.RowVersion,
				RowStatus = model.RowStatus,
				Code = model.Code,
				Name = model.Name,
				Type = model.Type,
				Basic = model.Basic,
				Unit = model.Unit,
				StartDate = model.StartDate,
				EndDate = model.EndDate,
				Description = model.Description,
				CreatedBy = model.CreatedBy,
				CreatedDate = model.CreatedDate,
				ModifiedBy = model.ModifiedBy,
				ModifiedDate = model.ModifiedDate,
			};
		}

		public override int Update(IBaseModel businessModel)
		{
			var model = businessModel as IPayrollGroupModel;
			if (model == null)
				throw new Exception(MessageModelNull);
			var query = (from d in Entities.PayrollGroups where d.Id == model.Id select d).FirstOrDefault();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			PopulateModelToNewEntity(query, model);
			return Entities.SaveChanges();
		}

		private void PopulateModelToNewEntity(PayrollGroup query, IPayrollGroupModel model)
		{
			query.Id = model.Id;
			query.RowVersion = model.RowVersion;
			query.RowStatus = model.RowStatus;
			query.Code = model.Code;
			query.Name = model.Name;
			query.Type = model.Type;
			query.Basic = model.Basic;
			query.Unit = model.Unit;
			query.StartDate = model.StartDate;
			query.EndDate = model.EndDate;
			query.Description = model.Description;
			query.CreatedBy = model.CreatedBy;
			query.CreatedDate = model.CreatedDate;
			query.ModifiedBy = model.ModifiedBy;
			query.ModifiedDate = model.ModifiedDate;
		}

		public override int Delete(int id)
		{
			var query = (from d in Entities.PayrollGroups where d.Id == id select d).FirstOrDefault();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			Entities.PayrollGroups.DeleteObject(query);
			return Entities.SaveChanges();
		}

		private static PayrollGroupModel PopulateEntityToNewModel(PayrollGroup item)
		{
			return new PayrollGroupModel
			{
				Id = item.Id,
				RowVersion = item.RowVersion,
				RowStatus = item.RowStatus,
				Code = item.Code,
				Name = item.Name,
				Type = item.Type,
				Basic = item.Basic,
				Unit = item.Unit,
				StartDate = item.StartDate,
				EndDate = item.EndDate,
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
			var query = (from a in Entities.PayrollGroups select a).Where(whereterm, ListValue.ToArray()).ToList();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			return query.Select(PopulateEntityToNewModel).Cast<IPayrollGroupModel>().ToList();
		}

		public override IEnumerable<IBaseModel> Get(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			ValidateSorting(ref sort, ref dir);
			var whereterm = GetQueryParameterLinq(parameter);
			var query = (from a in Entities.PayrollGroups select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir).Skip(start).Take(limit).ToList();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			var tquery = (from a in Entities.Positions select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir);
			totalCount = tquery.Count();
			return query.Select(PopulateEntityToNewModel).Cast<IPayrollGroupModel>().ToList();
		}

	}

}
