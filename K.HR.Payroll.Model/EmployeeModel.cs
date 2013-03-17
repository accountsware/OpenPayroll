using System;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Model
{
	public class EmployeeModel : IEmployeeModel
	{
		public int Id { get; set; }
		public byte RowStatus { get; set; }
		public byte[] RowVersion { get; set; }
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public byte CrudStatus { get; set; }
		public string NationalIDNumber { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string PositionName { get; set; }
		public DateTime BirthDate { get; set; }
		public string Gender { get; set; }
		public DateTime HiredDate { get; set; }
		public string MaritalStatus { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string BankName { get; set; }
		public string BankAccount { get; set; }
		public string PayrollGroupCode { get; set; }
	    public string EmployeeID { get; set; }
	    public bool IsTerminate { get; set; }
	    public DateTime? TerminateDate { get; set; }
	    public string TerminateDescription { get; set; }
	}
}
