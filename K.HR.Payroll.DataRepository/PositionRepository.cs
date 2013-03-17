using System;
using System.Collections.Generic;
using System.Linq;
using K.Common.Data;
using K.Common.Patterns;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model;

namespace K.HR.Payroll.DataRepository
{
	public class PositionRepository : BaseRepository
	{
		public PositionRepository()
		{
			ObjectName = "Employee Position";
		}

		public override int Save(IBaseModel businessModel)
		{
			var model = businessModel as IPositionModel;
			if (model == null)
				throw new Exception(MessageModelNull);
			var entity = PopulateModelToNewEntity(model);
			Entities.AddToPositions(entity);
			return Entities.SaveChanges();
		}

		private static Position PopulateModelToNewEntity(IPositionModel model)
		{
			return new Position
			       	{
						CreatedBy = model.CreatedBy,
						CreatedDate = model.CreatedDate,
						Id = model.Id,
						ModifiedBy = model.ModifiedBy,
						ModifiedDate = model.ModifiedDate,
						PositionName = model.PositionName,
						RowStatus = model.RowStatus
			       	};
		}

		public override int Update(IBaseModel businessModel)
		{
			var model = businessModel as IPositionModel;
			if (model == null)
				throw new Exception(MessageModelNull);
			var query = (from d in Entities.Positions where d.Id == model.Id select d).FirstOrDefault();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			PopulateModelToNewEntity(query, model);
			return Entities.SaveChanges();
		}

		private static void PopulateModelToNewEntity(Position query, IPositionModel model)
		{
			query.CreatedBy = model.CreatedBy;
			query.CreatedDate = model.CreatedDate;
			query.Id = model.Id;
			query.ModifiedBy = model.ModifiedBy;
			query.ModifiedDate = model.ModifiedDate;
			query.PositionName = model.PositionName;
			query.RowStatus = model.RowStatus;
		}

		public override int Delete(int id)
			{
				var query = (from d in Entities.Positions where d.Id == id select d).FirstOrDefault();
				if (query == null)
					throw new Exception(MessageEntityNotFound);
				Entities.Positions.DeleteObject(query);
				return Entities.SaveChanges();
			}

		private static PositionModel PopulateEntityToNewModel(Position item)
		{
			return new PositionModel
			{
				CreatedBy = item.CreatedBy,
				CreatedDate = item.CreatedDate,
				Id = item.Id,
				ModifiedBy = item.ModifiedBy,
				ModifiedDate = item.ModifiedDate,
				PositionName = item.PositionName,
				RowStatus = item.RowStatus
			};
		}

		public override IEnumerable<IBaseModel> Get(params WhereTerm[] parameter)
		{
			var whereterm = GetQueryParameterLinq(parameter);
			var query = (from a in Entities.Positions select a).Where(whereterm, ListValue.ToArray()).ToList();
			if (query == null)
			{
				throw new Exception(MessageEntityNotFound);
			}
			return query.Select(PopulateEntityToNewModel).Cast<IPositionModel>().ToList();
		}

		public override IEnumerable<IBaseModel> Get(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			ValidateSorting(ref sort, ref dir);
			var whereterm = GetQueryParameterLinq(parameter);
			var query = (from a in Entities.Positions select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir).Skip(start).Take(limit).ToList();
			if (query == null)
			{
				throw new Exception(MessageEntityNotFound);
			}
			var tquery = (from a in Entities.Positions select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir);
			totalCount = tquery.Count();
			return query.Select(PopulateEntityToNewModel).Cast<IPositionModel>().ToList();
		}
	}
}
