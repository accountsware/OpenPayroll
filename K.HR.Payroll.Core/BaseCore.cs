using System;
using System.Collections.Generic;
using K.Common;
using K.Common.Data;
using K.Common.Helpers;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Entities;

namespace K.HR.Payroll.Core
{
	public abstract class BaseCore : IDisposable
	{
		
		protected const System.Data.IsolationLevel TRANSACTION_ISOLATION = System.Data.IsolationLevel.ReadCommitted;
		protected kk_sp_payrollEntities Entities;
		
		protected BaseCore(kk_sp_payrollEntities entities)
		{
			Entities = entities;
		}

		protected BaseCore()
        {
            Message = string.Empty;
            IsSuccess = true;
            ErrorEventHandler += Facade_ErrorEventHandler;
        }

		protected BaseRepository Repository { get; set; }
		public bool IsSuccess { get; set; }
		public string Message { get; set; }
		public event EventHandler<OnErrorArgs> ErrorEventHandler;

		public abstract IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter);

		protected void OnErrorEventHandler(OnErrorArgs e)
		{
			var handler = ErrorEventHandler;
			if (handler != null) handler(this, e);
		}

		protected void Facade_ErrorEventHandler(object sender, OnErrorArgs e)
		{
			//LoggerService.Instance.Error("Error on " + sender.GetType(), e.CException);
			Message = ExceptionHelpers.GetMessage(e.CException);
			IsSuccess = false;
		}

		protected TimeSpan TimeOut
		{
			get
			{
				// TODO CONFIGUREABLE
				return TimeSpan.FromMinutes(30);
			}
		}

		protected void OpenConnection()
		{
			if (Entities.Connection.State != System.Data.ConnectionState.Open)
				Entities.Connection.Open();
		}

		protected void CloseConnection()
		{
			if (Entities.Connection.State != System.Data.ConnectionState.Closed)
				Entities.Connection.Close();
		}

		public virtual void Dispose()
		{
			if (Entities != null)
				Entities.Dispose();
		}

		protected string ObjectName { get; set; }

		protected string SaveSuccessMessage
		{
			get { return string.Format("{0} has been saved successfully", ObjectName); }
		}

		protected string UpdateSuccessMessage
		{
			get { return string.Format("{0} has been updated successfully", ObjectName); }
		}

		protected string DeleteSuccessMessage
		{
			get { return string.Format("{0} has been deleted successfully", ObjectName); }
		}

	}

	
}
