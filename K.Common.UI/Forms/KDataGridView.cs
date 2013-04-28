using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K.Common.UI.Forms
{
    public partial class KDataGridView : DataGridView
    {
        public KDataGridView()
        {
            InitializeComponent();
        }

        public KDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int GetRowValue(DataGridViewRow row, string columnName, int defaultValue)
        {
            return row.Cells[columnName].Value == null ? defaultValue : Convert.ToInt32(row.Cells[columnName].Value);
        }

        public string GetRowValue(DataGridViewRow row, string columnName, string defaultValue)
        {
            return row.Cells[columnName].Value == null ? defaultValue : Convert.ToString(row.Cells[columnName].Value);
        }

        public byte GetRowValue(DataGridViewRow row, string columnName, byte defaultValue)
        {
            return row.Cells[columnName].Value == null ? defaultValue : Convert.ToByte(row.Cells[columnName].Value);
        }

        public decimal GetRowValue(DataGridViewRow row, string columnName, decimal defaultValue)
        {
            return row.Cells[columnName].Value == null ? defaultValue : Convert.ToDecimal(row.Cells[columnName].Value);
        }

        public DateTime? GetRowValue(DataGridViewRow row, string columnName, DateTime? defaultValue)
        {
            return row.Cells[columnName].Value == null ? defaultValue : Convert.ToDateTime(row.Cells[columnName].Value);
        }

        public byte[] GetRowValue(DataGridViewRow row, string columnName, byte[] defaultValue)
        {
            return row.Cells[columnName].Value == null ? defaultValue : Convert.FromBase64String(GetRowValue(row, columnName, string.Empty));
        }

    }
}
