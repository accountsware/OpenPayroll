using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.Interfaces;
using K.Common.Patterns;

namespace K.Common.Helpers
{
    public static class DataHelpers
    {
        public static string GetMaskNumber(int value , int l )
        {
            return string.Format("{0}:D" + l + "", value);
        }

        public static string GetString(double? value)
        {
            return !value.HasValue ? string.Empty : value.Value.ToString();
        }

        public static string GetString(int value)
        {
            return value.ToString();
        }

        public static string GetString(int? value)
        {
            return !value.HasValue ? string.Empty : value.Value.ToString();
        }

        public static string GetString(DateTime? value)
        {
            //return !value.HasValue ? string.Empty : value.Value.ToString();
            return !value.HasValue ? string.Empty : value.Value.ToString(DefaultValue.DEFAULT_FORMAT_DATE);
        }

        public static string GetString(DateTime value)
        {
            return value.ToString(DefaultValue.DEFAULT_FORMAT_DATE);
        }

        public static string GetString(Boolean? value)
        {
            return !value.HasValue ? string.Empty : value.Value.ToString();
        }

        public static string GetString(Boolean value)
        {
            return value.ToString();
        }

        public static string GetCSV(IEnumerable<IBaseModel> model)
        {
            if (model == null) return string.Empty;
            var list = model.ToList();
            var prop = list[0].GetType().GetProperties();
            var result = new StringBuilder();
            var listproperties = new List<string>();
            foreach (var a in prop)
            {
                result.Append(a.Name + DefaultValue.DEFAULT_SEPARATOR);
                listproperties.Add(a.Name);
            }
            foreach (var a in list )
            {
                foreach (var field in listproperties)
                {
                    var property = a.GetType().GetProperty(field);
                    result.Append(property.GetValue(a, null) + DefaultValue.DEFAULT_SEPARATOR);
                }
            }
            return result.ToString();
        }

    }
}
