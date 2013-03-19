using System;
using System.Collections.Generic;
using System.IO;
using K.Common;
using K.Common.Data;
using K.Common.Helpers;
using K.Common.Interfaces;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Entities;

namespace K.HR.Payroll.Core
{
	public abstract class PayrollModuleCore : AbstractCore
	{
		
		protected kk_sp_payrollEntities Entities;
		
		protected PayrollModuleCore(kk_sp_payrollEntities entities)
		{
			Entities = entities;
		}

		protected PayrollModuleCore()
        {
            Message = string.Empty;
            IsSuccess = true;
            //ErrorEventHandler += Facade_ErrorEventHandler;
        }

		protected BaseRepository Repository { get; set; }
		//public event EventHandler<OnErrorArgs> ErrorEventHandler;


		//protected void OnErrorEventHandler(OnErrorArgs e)
		//{
		//    var handler = ErrorEventHandler;
		//    if (handler != null) handler(this, e);
		//}

		protected void Facade_ErrorEventHandler(object sender, OnErrorArgs e)
		{
			//LoggerService.Instance.Error("Error on " + sender.GetType(), e.CException);
			Message = ExceptionHelpers.GetMessage(e.CException);
			IsSuccess = false;
		}


		protected override void OpenConnection()
		{
			if (Entities.Connection.State != System.Data.ConnectionState.Open)
				Entities.Connection.Open();
		}

		protected override void CloseConnection()
		{
			if (Entities.Connection.State != System.Data.ConnectionState.Closed)
				Entities.Connection.Close();
		}

		public override void Dispose()
		{
			if (Entities != null)
				Entities.Dispose();
		}


	}

	
}
