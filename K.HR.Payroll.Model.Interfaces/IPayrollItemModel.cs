using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.HR.Payroll.Model.Interfaces
{
    public interface IPayrollItemModel : IBaseModel
    {
        int PayrolGroupId { get; set; }
        string Name { get; set; }
        string ItemType { get; set; }
        string Type { get; set; }
        decimal Value { get; set; }
        decimal Unit { get; set; }
        string Description { get; set; }
    }

}
