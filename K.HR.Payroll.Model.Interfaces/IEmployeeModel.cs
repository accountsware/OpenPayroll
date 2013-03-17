using System;
using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.HR.Payroll.Model.Interfaces
{
	public interface IEmployeeModel : IBaseModel
	{

		string NationalIDNumber { get; set; }

		string FirstName { get; set; }

		string MiddleName { get; set; }

		string LastName { get; set; }

		string Title { get; set; }

		string PositionName { get; set; }

		DateTime BirthDate { get; set; }

		string Gender { get; set; }

		DateTime HiredDate { get; set; }

		string MaritalStatus { get; set; }

		string Address { get; set; }

		string City { get; set; }

		string State { get; set; }

		string PostalCode { get; set; }

		string BankName { get; set; }

		string BankAccount { get; set; }

		string PayrollGroupCode { get; set; }
        string EmployeeID { get; set; }
        bool IsTerminate { get; set; }
        DateTime? TerminateDate { get; set; }
        string TerminateDescription { get; set; }

	}

}
