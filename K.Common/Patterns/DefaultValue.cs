﻿using System;

namespace K.Common.Patterns
{
    public static class DefaultValue
    {
        public const string AUTO_GENERATE_TEXT = @"Auto Generate";
        public const string DEFAULT_NEW_LINE_WEB = "<br/>";
		public const string DEFAULT_NEW_LINE_CONSOLE = "\n";
        public const string SQL_DATE_FORMAT = "yyyy-MM-dd hh:mm:ss";
        public const string DOT = ".";
        public const string LOGICAL_SQL = " AND ";
        public const string DEFAULT_DATE_STRING = "01/01/1900 00:00:00";
        public const string DEFAULT_FORMAT_DATE = "dd-MM-yyyy";
        public const string DEFAULT_SEPARATOR = "\t";
        public const string DEFAULT_EMPTY = "NONE";
        public const string FILE_UPLOAD_PATH = @"~\Upload\";
		public const string COLUMN_ROW_STATUS = "RowStatus";
        public const string CRUD_STATUS = "CrudStatusColumn";
        public static DateTime DefaultDate
        {
            get
            {
                return new DateTime(1900, 1, 1);
            }
        }
        
    }
}
