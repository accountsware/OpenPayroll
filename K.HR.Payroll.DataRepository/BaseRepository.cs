using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using K.Common.Data;
using K.Common.Helpers;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.Entities;

namespace K.HR.Payroll.DataRepository
{
	public abstract class BaseRepository : IDisposable
	{

		protected kk_sp_payrollEntities Entities;
		protected EntityConnection Connection;
		const string DATA_PROTECTION_PROVIDER = "DataProtectionConfigurationProvider";
		protected string ConnectionString;// = ConfigurationManager.ConnectionStrings["lexyEntities"].ConnectionString;
		
		protected BaseRepository()
		{
            ConnectionStringProtection(false);
            Connection = new EntityConnection(ConnectionString);
			Entities = new kk_sp_payrollEntities(Connection);
		}

		private void ConnectionStringProtection(bool protect)
		{
			try
			{

				var oConfiguration = ConfigurationHelpers.GetCurrentConfiguration();

				if (oConfiguration != null)
				{
					//var blnChanged = false;
					var oSection = oConfiguration.GetSection("connectionStrings") as ConnectionStringsSection;

					if (oSection != null)
					{
						if ((!(oSection.ElementInformation.IsLocked)) && (!(oSection.SectionInformation.IsLocked)))
						{
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
									ConnectionString = oSection.ConnectionStrings["LexyEntities"].ConnectionString;
								}
								else
								{
									ConnectionString = oSection.ConnectionStrings["LexyEntities"].ConnectionString;
									//oSection.SectionInformation.ProtectSection(DATA_PROTECTION_PROVIDER);
									//oSection.SectionInformation.ForceSave = true;
									//oConfiguration.Save();

									//var isweb = ConfigurationManager.AppSettings["IsWebApps"];
									//if (isweb.Equals("0"))
									//{
									//    oSection.SectionInformation.ProtectSection(DATA_PROTECTION_PROVIDER);
									//    oSection.SectionInformation.ForceSave = true;
									//    oConfiguration.Save();
									//}
								}
							}
						}
						else
						{
							throw new Exception("File Configuration is locked");
						}

						//if (blnChanged)
						//{
						//    oSection.SectionInformation.ForceSave = true;
						//    oConfiguration.Save();
						//}
					}
				}
			}
			catch (Exception ex)
			{
				// TODO ERROR User Privilages
				ConnectionString = ConfigurationManager.ConnectionStrings["lexyEntities"].ConnectionString;

			}
		}

		protected BaseRepository(kk_sp_payrollEntities entities)
        {
            ConnectionStringProtection(false);
			Entities = entities;
		}

		public abstract int Save(IBaseModel businessModel);

		public abstract int Update(IBaseModel businessModel);

		public abstract int Delete(int id);

		public abstract IEnumerable<IBaseModel> Get(params IListParameter[] parameter);

		public abstract IEnumerable<IBaseModel> Get(int start, int limit, string sort, string dir, out int totalCount,
		                                            params IListParameter[] parameter);

		//public abstract int Save<T>(ref T businessModel) where T : IBaseModel;

		//public abstract int Update<T>(ref T businessModel) where T : IBaseModel;

		//public abstract int Delete(int id);

		//public abstract IList<T> Get<T>() where T : IBaseModel;

		//public abstract IList<T> Get<T>(params WhereTerm[] parameter) where T : IBaseModel;

		//public abstract IList<T> Get<T>(int id) where T : IBaseModel;

		//public abstract IList<T> GetPaging<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter) where T : IBaseModel;

		protected string GetQueryParameterLinq(IEnumerable<IListParameter> lparams)
		{
			var listparams = new List<IListParameter>();
			if (lparams != null)
			{
				listparams.AddRange(lparams);
			}
			listparams.Add(WhereTerm.DefaultParam(0, "RowStatus"));
			var query = new StringBuilder();
			ListValue = new Collection<object>();
			var indexpass = 0;
			var d = listparams.Where(param => !string.IsNullOrEmpty(param.ColumnName)).ToList();
			listparams = d;
			foreach (var param in listparams)
			{
				var index = listparams.ToList().IndexOf(param) + indexpass;
				switch (param.ParamDataType)
				{
					case EnumParamterDataTypes.DateTime:
						{
							var date1 = Convert.ToDateTime(param.GetValue());
							var fdate = new DateTime(date1.Year, date1.Month, date1.Day, 0, 0, 0);
							var ldate = new DateTime(date1.Year, date1.Month, date1.Day, 23, 59, 59);
							var fparma = WhereTerm.DefaultParam(fdate, param.ColumnName, SqlOperator.GreatThanEqual);
							var lparma = WhereTerm.DefaultParam(ldate, param.ColumnName, SqlOperator.LesThanEqual);
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
							var ldate = new DateTime(date1.Year, date1.Month, date1.Day, 23, 59, 59);
							ListValue.Add(ldate);
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

		protected Collection<object> ListValue { get; set; }

		protected string ObjectName { get; set; }

		public virtual void Dispose()
		{
			if (Entities != null)
				Entities.Dispose();
		}

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

		protected void ValidateSorting(ref string sort,ref string dir)
		{
			if (string.IsNullOrEmpty(sort))
				sort = "Id";
			if (string.IsNullOrEmpty(dir))
				dir = "DESC";
		}

	}
}
