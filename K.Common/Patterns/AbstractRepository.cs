using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;
using K.Common.Data;
using K.Common.Helpers;
using K.Common.Interfaces;



namespace K.Common.Patterns
{
	public abstract class AbstractRepository : IDataManager
	{
		protected ObjectContext Entities;
		protected EntityConnection Connection;
		protected bool UsingTransaction;
		const string DATA_PROTECTION_PROVIDER = "DataProtectionConfigurationProvider";
		protected string ConnectionString = ConfigurationManager.ConnectionStrings["CurrentConnection"].ConnectionString;
		
		protected AbstractRepository()
		{
			ConnectionStringProtection(false);
			Connection = new EntityConnection(ConnectionString);
			UsingTransaction = false;
		}

		protected AbstractRepository(ObjectContext entities)
		{
			ConnectionStringProtection(false);
			Entities = entities;
			Connection = entities.Connection as EntityConnection;
			UsingTransaction = true;
		}

		protected Collection<object> ListValue { get; set; }

		public abstract int Save<T>(T businessModel) where T : IBaseModel;
		public abstract int Update<T>(T businessModel) where T : IBaseModel;
		public abstract int Delete(int id);
		public abstract IEnumerable<T> GetAll<T>() where T : IBaseModel;
		public abstract IEnumerable<T> Get<T>(params IListParameter[] parameter) where T : IBaseModel;
		public abstract T GetSingle<T>(params IListParameter[] parameter) where T : IBaseModel;
		public abstract IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter) where T : IBaseModel;
		
		private void ConnectionStringProtection(bool protect)
		{
			try
			{
				var oConfiguration = ConfigurationHelpers.GetCurrentConfiguration();
				if (oConfiguration == null) return;
				//var blnChanged = false;
				var oSection = oConfiguration.GetSection("connectionStrings") as ConnectionStringsSection;

				if (oSection == null) return;
				if ((oSection.ElementInformation.IsLocked) || (oSection.SectionInformation.IsLocked))
				{
					throw new Exception("File Configuration is locked");
				}
				if (protect)
				{
					if (!(oSection.SectionInformation.IsProtected))
					{
						oSection.SectionInformation.ProtectSection(DATA_PROTECTION_PROVIDER);
					}
				}
				else
				{
					if (oSection.SectionInformation.IsProtected)
					{
						oSection.SectionInformation.UnprotectSection();
						ConnectionString = oSection.ConnectionStrings["ConnectionStringEntities"].ConnectionString;
					}
					else
					{
						ConnectionString = oSection.ConnectionStrings["ConnectionStringEntities"].ConnectionString;
						var isweb = ConfigurationManager.AppSettings["IsWebApps"];
						if (isweb.Equals("0"))
						{
							oSection.SectionInformation.ProtectSection(DATA_PROTECTION_PROVIDER);
							oSection.SectionInformation.ForceSave = true;
							oConfiguration.Save();
						}
					}
				}

				//if (blnChanged)
				//{
				//    oSection.SectionInformation.ForceSave = true;
				//    oConfiguration.Save();
				//}
			}
			catch (Exception ex)
			{
				ConnectionString = ConfigurationManager.ConnectionStrings["lexyEntities"].ConnectionString;
				Console.WriteLine(ex.Message);
			}
		}

		public void Dispose()
		{
			if (UsingTransaction) return;
			if (Entities != null)
				Entities.Dispose();
		}

		protected string ObjectName { get; set; }

		protected string MessageEntityNull
		{
			get { return string.Format("{0} Entity is NULL", ObjectName); }
		}

		protected string MessageModelNull
		{
			get { return string.Format("{0} Model is NULL", ObjectName); }
		}

		protected string MessageEntityNotFound
		{
			get { return string.Format("{0} Entity not found", ObjectName); }
		}

		protected void ValidateSorting(ref string sort, ref string dir)
		{
			if (string.IsNullOrEmpty(sort))
				sort = "Id";
			if (string.IsNullOrEmpty(dir))
				dir = "DESC";
		}

		public string GetQueryParameterLinq(params IListParameter[] parameters)
		{
			var hasRowParams = WhereTerm.ResizeParameter(ref parameters, 1);
			if (!hasRowParams)
				parameters[parameters.Length - 1] = WhereTerm.Parameter(0, DefaultValue.COLUMN_ROW_STATUS);
			var query = new StringBuilder();
			ListValue = new Collection<object>();
			var indexpass = 0;
			foreach (var param in parameters)
			{
				var index = parameters.ToList().IndexOf(param) + indexpass;
				switch (param.ParamDataType)
				{
					case EnumParamterDataTypes.DateTime:
						{
							var date1 = Convert.ToDateTime(param.GetValue());
							var fdate = new DateTime(date1.Year, date1.Month, date1.Day, 0, 0, 0);
							var ldate = new DateTime(date1.Year, date1.Month, date1.Day, 23, 59, 59);
							var fparma = WhereTerm.Parameter(fdate, param.ColumnName, SqlOperator.GreatThanEqual);
							var lparma = WhereTerm.Parameter(ldate, param.ColumnName, SqlOperator.LesThanEqual);
							query.Append(GetValueParameterLinq(fparma, index) + DefaultValue.LOGICAL_SQL);
							ListValue.Add(fparma.GetValue());
							index++;
							indexpass++;
							query.Append(GetValueParameterLinq(lparma, index) + DefaultValue.LOGICAL_SQL);
							ListValue.Add(lparma.GetValue());
						}
						break;
					case EnumParamterDataTypes.DateTimeRange:
						{
							query.Append(GetValueParameterLinq(param, index) + DefaultValue.LOGICAL_SQL);
							ListValue.Add(param.GetValue());
							var date1 = Convert.ToDateTime(((IListRangeParameter)param).GetValue2());
							//var ldate = new DateTime(date1.Year, date1.Month, date1.Day, 23, 59, 59);
							ListValue.Add(date1);
							indexpass++;
						}
						break;
					default:
						query.Append(GetValueParameterLinq(param, index) + DefaultValue.LOGICAL_SQL);
						ListValue.Add(param.GetValue());
						break;
				}
			}
			if (query.Length != 0)
			{

				var qresult = query.ToString().Trim();
				if (qresult.Substring(qresult.Length - 3, 3) == DefaultValue.LOGICAL_SQL.Trim())
				{
					qresult = qresult.Remove(qresult.Length - 3, 3);
				}
				return qresult;
			}
			return query.ToString();
		}
		
		/// <summary>
		/// {0} Table Name
		/// {1} Column Name
		/// {2} Operator
		/// </summary>
		/// <param name="param"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		private static string GetValueParameterLinq(IListParameter param, int index)
		{
			switch (param.ParamDataType)
			{
				case EnumParamterDataTypes.Number:
					return GetNumericLinq(param, index);
				case EnumParamterDataTypes.NumberRange:
					return GetNumericLinq(param, index);
				case EnumParamterDataTypes.DateTime:
					return GetDateTimeLinq(param, index);
				case EnumParamterDataTypes.DateTimeRange:
					return GetDateTimeRangeLinq(param as IListRangeParameter, index);
				case EnumParamterDataTypes.Bool:
					return GetBooleanLinq(param, index);
				default:
					return GetCharacterLinq(param, index);
			}
		}

		/// <summary>
		/// {0} Table Name
		/// {1} Column Name
		/// {2} Operator
		/// </summary>
		/// <param name="param"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		private static string GetCharacterLinq(IListParameter param, int index)
		{
			//ListValue.Add(param.GetValue());
			//return string.Format(" ({0}{1}{2}) ",
			//    (string.IsNullOrEmpty(param.TableName) ? string.Empty : param.TableName + DefaultValue.DOT),
			//    param.ColumnName, GetOperatorCharacterLinq(param.Operator, index));
			return string.Format(" ({0}{1}{2}) ",
				string.Empty,
				param.ColumnName, GetOperatorCharacterLinq(param.Operator, index));
		}

		private static string GetOperatorCharacterLinq(SqlOperator @operator, int param)
		{
			switch (@operator)
			{
				case SqlOperator.NotEqual:
					return string.Format("<> @{0}", param);
				case SqlOperator.GreatThan:
					return string.Format("> @{0}", param);
				case SqlOperator.GreatThanEqual:
					return string.Format(">= @{0}", param);
				case SqlOperator.LessThan:
					return string.Format("< @{0}", param);
				case SqlOperator.LesThanEqual:
					return string.Format("<= @{0}", param);
				case SqlOperator.BeginWith:
					return string.Format(".StartsWith(@{0})", param);
				case SqlOperator.EndWith:
					return string.Format(".EndsWith(@{0})", param);
				case SqlOperator.Like:
					return string.Format(".Contains(@{0})", param);
				default:
					return string.Format(".Equals(@{0})", param);
			}
		}

		private static string GetBooleanLinq(IListParameter control, int index)
		{
			return string.Format(" ({0}{1} {2}) ",
								 string.Empty,
								 control.ColumnName, GetOperatorBooleanLinq(control.Operator, index));
		}

		private static string GetOperatorBooleanLinq(SqlOperator sqlOperator, int index)
		{
			switch (sqlOperator)
			{
				case SqlOperator.NotEqual:
					return string.Format("!= @{0}", index);
				default:
					return string.Format("= @{0}", index);
			}
		}

		private static string GetDateTimeRangeLinq(IListRangeParameter rangecontrol, int index)
		{
			if (rangecontrol == null) return null;
			return string.Format(" ({0} {1} @{2} AND {3} {4} @{5})",
								 rangecontrol.ColumnName, ">=",
								 index,
								  rangecontrol.ColumnName2, "<=",
								 index + 1);
		}

		private static string GetDateTimeLinq(IListParameter param, int index)
		{
			//return string.Format(" ({0}{1}{2}) ", (string.IsNullOrEmpty(param.TableName) ? string.Empty : param.TableName + DefaultValue.DOT),
			//    param.ColumnName, GetOperatorDateTimeLinq(param.Operator, index));
			return string.Format(" ({0}{1}{2}) ", string.Empty,
				param.ColumnName, GetOperatorDateTimeLinq(param.Operator, index));
		}

		private static object GetOperatorDateTimeLinq(SqlOperator sqlOperator, int index)
		{
			switch (sqlOperator)
			{
				case SqlOperator.NotEqual:
					return new StringBuilder().AppendFormat("<> @{0}", index);
				case SqlOperator.GreatThan:
					return new StringBuilder().AppendFormat("> @{0}", index);
				case SqlOperator.GreatThanEqual:
					return new StringBuilder().AppendFormat(">= @{0}", index);
				case SqlOperator.LessThan:
					return new StringBuilder().AppendFormat("< @{0}", index);
				case SqlOperator.LesThanEqual:
					return new StringBuilder().AppendFormat("<= @{0}", index);
				default:
					return new StringBuilder().AppendFormat("= @{0}", index);
			}
		}

		private static string GetNumericLinq(IListParameter param, int index)
		{
			//return string.Format(" ({0}{1}{2}) ",
			//                     (string.IsNullOrEmpty(param.TableName) ? string.Empty : param.TableName + DefaultValue.DOT),
			//                     param.ColumnName, GetOperatorNumberLinq(param.Operator, index));
			return string.Format(" ({0}{1}{2}) ",
								 string.Empty,
								 param.ColumnName, GetOperatorNumberLinq(param.Operator, index));
		}

		private static StringBuilder GetOperatorNumberLinq(SqlOperator sqloperator, int index)
		{
			switch (sqloperator)
			{
				case SqlOperator.NotEqual:
					return new StringBuilder().AppendFormat("<> @{0}", index);
				case SqlOperator.GreatThan:
					return new StringBuilder().AppendFormat("> @{0}", index);
				case SqlOperator.GreatThanEqual:
					return new StringBuilder().AppendFormat(">= @{0}", index);
				case SqlOperator.LessThan:
					return new StringBuilder().AppendFormat("< @{0}", index);
				case SqlOperator.LesThanEqual:
					return new StringBuilder().AppendFormat("<= @{0}", index);
				default:
					return new StringBuilder().AppendFormat("= @{0}", index);
			}
		}

		protected void OpenConnection()
		{
			if (Connection.State != System.Data.ConnectionState.Open)
				Connection.Open();
		}

		protected void CloseConnection()
		{
			if (Connection.State != System.Data.ConnectionState.Closed)
				Connection.Close();
		}
		
	}
}
