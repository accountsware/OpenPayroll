using System;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Model
{
	public class PositionModel : IPositionModel
	{
		public int Id { get; set; }
		public byte RowStatus { get; set; }
		public byte[] RowVersion { get; set; }
		public DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string PositionName { get; set; }
        public byte CrudStatus { get; set; }
	}
}
