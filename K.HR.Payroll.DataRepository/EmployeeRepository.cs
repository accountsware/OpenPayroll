using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.Data;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.Entities;
using K.HR.Payroll.Model;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.DataRepository
{
	public class EmployeeRepository : BaseRepository
	{
		public EmployeeRepository()
		{
			ObjectName = "Employee";
		}

		public override int Save(IBaseModel businessModel)
		{
			var model = businessModel as IEmployeeModel;
			if (model == null)
				throw new Exception(MessageModelNull);
			var entity = PopulateModelToNewEntity(model);
			Entities.AddToEmployees(entity);
			return Entities.SaveChanges();
		}

		private static Employee PopulateModelToNewEntity(IEmployeeModel model)
		{
			return new Employee
			       	{
			       		Address = model.Address,
			       		BankAccount = model.BankAccount,
			       		BankName = model.BankName,
			       		BirthDate = model.BirthDate,
			       		City = model.City,
			       		CreatedBy = model.CreatedBy,
			       		CreatedDate = model.CreatedDate,
			       		FirstName = model.FirstName,
			       		Gender = model.Gender,
			       		HiredDate = model.HiredDate,
			       		Id = model.Id,
			       		LastName = model.LastName,
			       		MaritalStatus = model.MaritalStatus,
			       		MiddleName = model.MiddleName,
			       		ModifiedBy = model.ModifiedBy,
			       		ModifiedDate = model.ModifiedDate,
			       		NationalIDNumber = model.NationalIDNumber,
			       		PayrollGroupCode = model.PayrollGroupCode,
			       		PositionName = model.PositionName,
			       		PostalCode = model.PostalCode,
			       		RowStatus = model.RowStatus,
			       		State = model.State,
			       		Title = model.Title,
                        EmployeeID =  model.EmployeeID,
                        IsTerminate = model.IsTerminate,
                        TerminateDate = model.TerminateDate,
                        TerminateDescription = model.TerminateDescription
			       	};
		}

		public override int Update(IBaseModel businessModel)
		{
			var model = businessModel as IEmployeeModel;
			if (model == null)
				throw new Exception(MessageModelNull);
			var query = (from d in Entities.Employees where d.Id == model.Id select d).FirstOrDefault();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			PopulateModelToNewEntity(query, model);
			return Entities.SaveChanges();
		}

		private static void PopulateModelToNewEntity(Employee query, IEmployeeModel model)
		{
			query.Address = model.Address;
			query.BankAccount = model.BankAccount;
			query.BankName = model.BankName;
			query.BirthDate = model.BirthDate;
			query.City = model.City;
			query.CreatedBy = model.CreatedBy;
			query.CreatedDate = model.CreatedDate;
			query.FirstName = model.FirstName;
			query.Gender = model.Gender;
			query.HiredDate = model.HiredDate;
			query.Id = model.Id;
			query.LastName = model.LastName;
			query.MaritalStatus = model.MaritalStatus;
			query.MiddleName = model.MiddleName;
			query.ModifiedBy = model.ModifiedBy;
			query.ModifiedDate = model.ModifiedDate;
			query.NationalIDNumber = model.NationalIDNumber;
			query.PayrollGroupCode = model.PayrollGroupCode;
			query.PositionName = model.PositionName;
			query.PostalCode = model.PostalCode;
			query.RowStatus = model.RowStatus;
			query.State = model.State;
			query.Title = model.Title;
		    query.EmployeeID = model.EmployeeID;
		    query.IsTerminate = model.IsTerminate;
		    query.TerminateDate = model.TerminateDate;
		    query.TerminateDescription = model.TerminateDescription;
		}

		public override int Delete(int id)
		{
			var query = (from d in Entities.Employees where d.Id == id select d).FirstOrDefault();
			if (query == null)
				throw new Exception(MessageEntityNotFound);
			Entities.Employees.DeleteObject(query);
			return Entities.SaveChanges();
		}


		private static EmployeeModel PopulateEntityToNewModel(Employee item)
		{
			return new EmployeeModel
			       	{
			       		Address = item.Address, BankAccount = item.BankAccount, BankName = item.BankName, BirthDate = item.BirthDate, City = item.City, CreatedBy = item.CreatedBy, CreatedDate = item.CreatedDate, FirstName = item.FirstName, Gender = item.Gender, HiredDate = item.HiredDate, Id = item.Id, LastName = item.LastName, MaritalStatus = item.MaritalStatus, MiddleName = item.MiddleName, ModifiedBy = item.ModifiedBy, ModifiedDate = item.ModifiedDate, NationalIDNumber = item.NationalIDNumber, PayrollGroupCode = item.PayrollGroupCode, PositionName = item.PositionName, PostalCode = item.PostalCode, RowStatus = item.RowStatus, State = item.State, Title = item.Title, EmployeeID = item.EmployeeID, IsTerminate = item.IsTerminate, TerminateDate = item.TerminateDate, TerminateDescription = item.TerminateDescription
			       	};
		}

		public override IEnumerable<IBaseModel> Get(params IListParameter[] parameter)
		{
			var whereterm = GetQueryParameterLinq(parameter);
			var query = (from a in Entities.Employees select a).Where(whereterm, ListValue.ToArray()).ToList();
			if (query == null)
			{
				throw new Exception(MessageEntityNotFound);
			}
			return query.Select(PopulateEntityToNewModel).Cast<IEmployeeModel>().ToList();
		}

		public override IEnumerable<IBaseModel> Get(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
		{
			ValidateSorting(ref sort,ref dir);
			var whereterm = GetQueryParameterLinq(parameter);
			var query = (from a in Entities.Employees select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir).Skip(start).Take(limit).ToList();
			if (query == null)
			{
				throw new Exception(MessageEntityNotFound);
			}
			var tquery = (from a in Entities.Employees select a).Where(whereterm, ListValue.ToArray()).OrderBy(sort + " " + dir);
			totalCount = tquery.Count();
			return query.Select(PopulateEntityToNewModel).Cast<IEmployeeModel>().ToList();
		}
	}
}
