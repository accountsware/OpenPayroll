using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.HR.Payroll.Model.Interfaces
{
    public interface ICityModel : IBaseModel
    {
        string CityName { get; set; }
    }

}
