using K.Common.Patterns;

namespace K.HR.Payroll.Model.Interfaces
{
	public interface IPositionModel : IBaseModel
	{
		string PositionName { get; set; }
	}
}
