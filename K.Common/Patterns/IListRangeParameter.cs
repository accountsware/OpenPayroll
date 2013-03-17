namespace K.Common.Patterns
{
    public interface IListRangeParameter : IListParameter
    {
        object GetValue2();
        string TableName2 { get; set; }
        string ColumnName2 { get; set; }
		bool HasValue2 { get;  }
    }
}
