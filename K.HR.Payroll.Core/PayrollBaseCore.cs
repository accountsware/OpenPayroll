using K.Common;
using K.Common.Helpers;
using K.Common.Patterns;
using K.HR.Payroll.DataRepository;
using K.HR.Payroll.Entities;

namespace K.HR.Payroll.Core
{
	public abstract class PayrollBaseCore : AbstractCore
	{
		
		protected kk_sp_payrollEntities Entities;
		
		protected PayrollBaseCore(kk_sp_payrollEntities entities)
		{
			Entities = entities;
            IsSuccess = true;
		}

		protected PayrollBaseCore()
        {
            Message = string.Empty;
            IsSuccess = true;
        }

		protected PayrollBaseRepository Repository { get; set; }


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
