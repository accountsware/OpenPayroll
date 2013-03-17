namespace K.Common.Data
{
    public class JsonReturnBase
    {
        public JsonReturnBase()
        {
            msg = "No value for message field";
            success = true;
            totalCount = 0;
            root = "[]";
            result = false;
        }
// ReSharper disable InconsistentNaming
        public string msg { get; set; }

        public bool success { get; set; }
        public bool result { get; set; }
        public int totalCount { get; set; }
        public string root { get; set; }
        // ReSharper restore InconsistentNaming
    }
}
