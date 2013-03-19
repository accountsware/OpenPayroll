using System;
using System.Collections.Generic;
using K.Common.Interfaces;

namespace K.Common.Patterns
{
	public abstract class AbstractCore : IDisposable
	{
		protected const System.Data.IsolationLevel TRANSACTION_ISOLATION = System.Data.IsolationLevel.ReadCommitted;

		protected AbstractCore()
		{
			Message = string.Empty;
			IsSuccess = true;
			//ErrorEventHandler += Facade_ErrorEventHandler;
		}

		public bool IsSuccess { get; set; }
		public string Message { get; set; }

		public abstract IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter);

		protected TimeSpan TimeOut
		{
			get
			{
				// TODO CONFIGUREABLE
				return TimeSpan.FromMinutes(30);
			}
		}

		protected abstract void OpenConnection();

		protected abstract void CloseConnection();

		public abstract void Dispose();

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
