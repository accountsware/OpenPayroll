using K.Common.Data;

namespace K.Common.Patterns
{
    public class TemplateField : ITemplateField
    {
        public int Number { get; set; }

        public string PropertyName { get; set; }

        public string HeaderName { get; set; }

        public EnumParamterDataTypes DataType { get; set; }

        public string FormatData { get; set; }
    }
}
