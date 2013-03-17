using System;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Model
{
	public class PayrollGroupModel : IPayrollGroupModel
	{
		public int Id { get; set; }
		public byte RowStatus { get; set; }
		public byte[] RowVersion { get; set; }
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
	    public string Code { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public decimal Basic { get; set; }
		public byte Unit { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Description { get; set; }
        public byte CrudStatus { get; set; }
	}
}
