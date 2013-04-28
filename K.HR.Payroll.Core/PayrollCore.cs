using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.Interfaces;

namespace K.HR.Payroll.Core
{
    public class PayrollCore : PayrollBaseCore
    {
        public static IEnumerable<String> GetTypeItem()
        {
            return new List<String> { "EARNINGS", "DEDUCTIONS" }; ;
        }

        public static IEnumerable<String> GetUnitTypeItem()
        {
            return new List<String> { "BASE-ON-VALUE", "PERCENTAGE-VALUE", "UNIT-VALUE" };
        }

        public override IEnumerable<T> Get<T>(int start, int limit, string sort, string dir, out int totalCount, params IListParameter[] parameter)
        {
            throw new NotImplementedException();
        }
    }
}
