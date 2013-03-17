using System;
using K.Common.Patterns;

namespace K.Common.Data
{
    public class WhereTerm : IListParameter
    {
        public string TableName { get; set; }

        public string ColumnName { get; set; }

        public EnumParamterDataTypes ParamDataType { get; set; }
        
        public object GetValue()
        {
            return Value;
        }

        public SqlOperator Operator { get; set; }

        public bool HasValue
        {
            get { return Value != null; }
        }

        public object Value { get; set; }

        public static WhereTerm DefaultParam(string value, string column)
        {
            return new WhereTerm
                       {
                           Value = value,
                           TableName = "",
                           ParamDataType = EnumParamterDataTypes.Character,
                           Operator = SqlOperator.Equals,
                           ColumnName = column
                       };
        }

        public static WhereTerm DefaultParam(DateTime value, string column, SqlOperator sqlOperator)
        {
            return new WhereTerm
            {
                Value = value,
                TableName = "",
                ParamDataType = EnumParamterDataTypes.DateTime,
                Operator = sqlOperator,
                ColumnName = column
            };
        }

        public static WhereTerm DefaultParam(DateTime value, string column)
        {
            return new WhereTerm
            {
                Value = value,
                TableName = "",
                ParamDataType = EnumParamterDataTypes.DateTime,
                Operator = SqlOperator.Equals,
                ColumnName = column
            };
        }

        public static WhereTerm DefaultParam(string value, string column, SqlOperator oSqlOperator)
        {
            return new WhereTerm
            {
                Value = value,
                TableName = "",
                ParamDataType = EnumParamterDataTypes.Character,
                Operator = oSqlOperator,
                ColumnName = column
            };
        }

        public static WhereTerm DefaultParam(bool value, string column)
        {
            return new WhereTerm
            {
                Value = value,
                TableName = "",
                ParamDataType = EnumParamterDataTypes.Bool,
                Operator = SqlOperator.Equals,
                ColumnName = column
            };
        }

        public static WhereTerm DefaultParam(int value, string column)
        {
            return new WhereTerm
            {
                Value = value,
                TableName = "",
                ParamDataType = EnumParamterDataTypes.Number,
                Operator = SqlOperator.Equals,
                ColumnName = column
            };
        }
    }
}
