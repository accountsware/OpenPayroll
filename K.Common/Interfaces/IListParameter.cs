using K.Common.Data;

namespace K.Common.Interfaces
{
	public interface IListParameter
	{
		EnumParamterDataTypes ParamDataType { get; set; }
		object GetValue();
        string TableName { get; set; }
        string ColumnName { get; set; }
		SqlOperator Operator { get; set; }
		bool HasValue { get; }
	}
}
