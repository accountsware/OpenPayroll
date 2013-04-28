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
using K.Common.Patterns;
using K.HR.Payroll.Entities;

namespace K.HR.Payroll.DataRepository
{
    public abstract class PayrollBaseRepository : BaseRepository
	{

		protected kk_sp_payrollEntities Entities;
		
		protected PayrollBaseRepository()
		{
            Connection = new EntityConnection(ConnectionString);
			Entities = new kk_sp_payrollEntities(Connection);
		}

		protected PayrollBaseRepository(kk_sp_payrollEntities entities) :base(entities)
        {
			Entities = entities;
		}

		public override void Dispose()
		{
            base.Dispose();
			if (Entities != null)
				Entities.Dispose();
		}

	}
}
