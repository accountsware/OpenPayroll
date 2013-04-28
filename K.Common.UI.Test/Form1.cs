using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K.Common.UI.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            var source = new List<PahlawanKota>
                {
                    new PahlawanKota
                        {
                          Keterangan   =  "Lest Hang out", Kota = "Jakarta", Nama = "Si Pitung"
                        },
                    new PahlawanKota
                        {
                            Kota = "Bandung", Nama = "Dewi Sartika", Keterangan = "Pileuleuyan"
                        },
                    new PahlawanKota
                        {
                            Kota = "Medan", Nama = "TB Simatupang", Keterangan = "Horas"
                        }
                };
            bindingSource1.DataSource = source;
        }

        public class PahlawanKota
        {
            public string Nama { get; set; }
            public string Kota { get; set; }
            public string Keterangan { get; set; }
        }
    }
}
