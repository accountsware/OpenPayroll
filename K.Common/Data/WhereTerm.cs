using System;
using System.Linq;
using K.Common.Interfaces;
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

		public static bool ResizeParameter(ref IListParameter[] parameters, int size)
		{
			var hasRowParams = false;
			if (parameters == null)
			{
				Array.Resize(ref parameters, size);
			}
			else
			{
				if (parameters.Any(param => param.ColumnName.Equals(DefaultValue.COLUMN_ROW_STATUS)))
					hasRowParams = true;
				if (!hasRowParams)
					Array.Resize(ref parameters, parameters.Length + size);
			}
			return hasRowParams;
		}

		/// <summary>
		/// To create where term condition with default value TableName = string.Empty, ParamDataType = EnumParamterDataTypes.DateTime
		/// </summary>
		/// <param name="value">Fill DateTime value of where term</param>
		/// <param name="column">Fill string value of column name</param>
		/// <param name="sqlOperator">Fill sql operator</param>
		/// <returns>WhereTerm</returns>
		public static WhereTerm Parameter(DateTime value, string column, SqlOperator sqlOperator)
		{
			return new WhereTerm
			{
				Value = value,
				TableName = String.Empty,
				ParamDataType = EnumParamterDataTypes.DateTime,
				Operator = sqlOperator,
				ColumnName = column
			};
		}

		/// <summary>
		/// To create where term condition with default value TableName = string.Empty, ParamDataType = EnumParamterDataTypes.DateTime
		/// </summary>
		/// <param name="value">Fill integer value of where term</param>
		/// <param name="column">Fill string value of column name</param>
		/// <param name="sqlOperator">Fill sql operator</param>
		/// <returns>WhereTerm</returns>
		public static WhereTerm Parameter(int value, string column, SqlOperator sqlOperator)
		{
			return new WhereTerm
			{
				Value = value,
				TableName = String.Empty,
				ParamDataType = EnumParamterDataTypes.Number,
				Operator = sqlOperator,
				ColumnName = column
			};
		}

		/// <summary>
		/// To create where term condition with default value TableName = string.Empty, ParamDataType = EnumParamterDataTypes.Number & Operator = SqlOperator.Equals
		/// </summary>
		/// <param name="value">Fill int value of where term</param>
		/// <param name="column">Fill string value of column name</param>
		/// <returns>WhereTerm</returns>
		public static WhereTerm Parameter(int value, string column)
		{
			return new WhereTerm
			{
				Value = value,
				TableName = String.Empty,
				ParamDataType = EnumParamterDataTypes.Number,
				Operator = SqlOperator.Equals,
				ColumnName = column
			};
		}
    }
}
