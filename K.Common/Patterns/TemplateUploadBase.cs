using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using K.Common.Data;

namespace K.Common.Patterns
{
    public class TemplateExportBase : ITemplateExport
    {
        protected TemplateExportBase()
        {
            IsStaticFileName = true;
        }

        const string ERROR_CAST = "#ERR-CAST";

        public bool IsStaticFileName { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public IEnumerable<ITemplateField> Fields { get; set; }

        public bool HasHeader { get; set; }

        public void CreateFile()
        {
            if (!IsValid()) return;
            var list = Models.ToList();
            var fields = Fields.OrderBy(a => a.Number).ToList();
            var prop = list[0].GetType().GetProperties();
            var result = new StringBuilder();
            var listproperties = new List<string>();
            if (HasHeader)
            {
                foreach (var field in fields)
                {
                    var jfield = prop.Where(a => a.Name.Equals(field.PropertyName)).FirstOrDefault();
                    if (jfield != null)
                    {
                        result.Append(jfield.Name + DefaultValue.DEFAULT_SEPARATOR);
                    }
                }
                result.AppendLine();
            }
            var msg = new StringBuilder();
            var index = 0;
            foreach (var a in list)
            {                
                foreach (var field in fields)
                {
                    var property = a.GetType().GetProperty(field.PropertyName);
                    switch (field.DataType)
                    {
                        case EnumParamterDataTypes.Number:
                            try
                            {
                                //var z = Convert.ToDouble(property.GetValue(a, null));
                                //result.Append(z.ToString(field.FormatData) + DefaultValue.DEFAULT_SEPARATOR);
                                var z = property.GetValue(a, null);
                                if (z != null)
                                    result.Append(Convert.ToDouble(z).ToString(field.FormatData) + DefaultValue.DEFAULT_SEPARATOR);
                                else
                                    result.Append(NullValue + DefaultValue.DEFAULT_SEPARATOR);
                            }
                            catch (Exception err)
                            {
                                SetError(result, msg, index, err);
                            }
                            break;
                        case EnumParamterDataTypes.NumberRange:
                            break;
                        case EnumParamterDataTypes.DateTime:
                            try
                            {
                                var z = property.GetValue(a, null);
                                if (z != null)
                                    result.Append(Convert.ToDateTime(z).ToString(field.FormatData) + DefaultValue.DEFAULT_SEPARATOR);
                                else
                                    result.Append(NullValue + DefaultValue.DEFAULT_SEPARATOR);
                            }
                            catch (Exception err)
                            {
                                SetError(result, msg, index, err);
                            }
                            break;
                        case EnumParamterDataTypes.DateTimeRange:
                            break;
                        case EnumParamterDataTypes.Bool:
                            try
                            {
                                var z = property.GetValue(a, null);
                                if (z != null)
                                    result.Append(Convert.ToBoolean(z).ToString() + DefaultValue.DEFAULT_SEPARATOR);
                                else
                                    result.Append(NullValue + DefaultValue.DEFAULT_SEPARATOR);
                            }
                            catch (Exception err)
                            {
                                SetError(result, msg, index, err);
                            }
                            break;
                        default:
                            var c = property.GetValue(a, null);
                            result.Append((c == null ? NullValue : c.ToString()) + DefaultValue.DEFAULT_SEPARATOR);
                            break;
                    }
                    
                }
                result.AppendLine();
                index++;
            }
            ErrorMessage = msg.ToString();
            if (msg.Length > 0) return;

            using (var writer = System.IO.File.CreateText(FilePath + FileName))
            {
                writer.Write(result.ToString());
            }
        }

        private static void SetError(StringBuilder result, StringBuilder msg, int index, Exception err)
        {
            msg.AppendFormat("LINE {0} : {1}", index, err.Message);
            msg.AppendLine();
            result.Append(ERROR_CAST + DefaultValue.DEFAULT_SEPARATOR);
        }
        
        public IEnumerable<IBaseModel> Models { get; set; }

        public bool IsValid()
        {
            var msg = new StringBuilder();
            if (Models == null && Models.Count() == 0)
                msg.AppendLine("Data Model can't be empty");
            if (Fields == null && Fields.Count() == 0)
                msg.AppendLine("Field Template can't be empty");
            ErrorMessage = msg.ToString();
            return msg.Length == 0;
        }
        
        public string ErrorMessage { get; set; }


        public string NullValue { get; set; }
    }
}
