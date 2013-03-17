using System;
using K.HR.Payroll.Model.Interfaces;

namespace K.HR.Payroll.Model
{
    public class PayrollItemModel : IPayrollItemModel
    {
        public int Id { get; set; }
        public byte RowStatus { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int PayrolGroupId { get; set; }
        public string Name { get; set; }
        public string ItemType { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public decimal Unit { get; set; }
        public string Description { get; set; }
        public byte CrudStatus { get; set; }
    }
}
