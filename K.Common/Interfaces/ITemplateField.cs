using K.Common.Data;

namespace K.Common.Interfaces
{
    public interface ITemplateField
    {
        /// <summary>
        /// No urut Kolom yang akan di upload
        /// </summary>
        int Number { get; set; }
        /// <summary>
        /// Nama Property Business Model, yang akan digenerate datanya
        /// </summary>
        string PropertyName { get; set; }
        /// <summary>
        /// Nama kolumn yang akan ditampilkan dalam file CVS
        /// </summary>
        string HeaderName { get; set; }
        /// <summary>
        /// Tipe Data 
        /// </summary>
        EnumParamterDataTypes DataType { get; set; }
        /// <summary>
        /// Format data .NET ex. Date (dd MMM yyyy), number (###.00), bool false|true
        /// </summary>
        string FormatData { get; set; }

    }
}
