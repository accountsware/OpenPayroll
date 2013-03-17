using System.Collections.Generic;

namespace K.Common.Patterns
{
    public interface ITemplateExport
    {
        /// <summary>
        /// Is File yang akan digenerate static or dynamic, 
        /// static file name berdasarkan Property FileName.
        /// dynamic file name berdasarkan Property FileName + DateTimeNow
        /// </summary>
        bool IsStaticFileName { get; set; }
        /// <summary>
        /// Represent value if feild exported is null
        /// </summary>
        string NullValue { get; set; }
        /// <summary>
        /// Nama File yang akan di generate
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// Path File, defaultnya Application.StartupPath
        /// </summary>
        string FilePath { get; set; }
        /// <summary>
        /// List Field yang akan di generate
        /// </summary>
        IEnumerable<ITemplateField> Fields { get; set; }
        /// <summary>
        /// List Source data yang akan digenerate
        /// </summary>
        IEnumerable<IBaseModel> Models { get; set; }
        /// <summary>
        /// Content file menggunakan header ?
        /// </summary>
        bool HasHeader { get; set; }
        /// <summary>
        /// creete file csv 
        /// </summary>
        void CreateFile();
        /// <summary>
        /// Validasi sebelum exec. create file csv
        /// </summary>
        /// <returns></returns>
        bool IsValid();
        /// <summary>
        /// If IsValid() return false, this property will contains error message
        /// </summary>
        string ErrorMessage { get; set; }

    }
}
