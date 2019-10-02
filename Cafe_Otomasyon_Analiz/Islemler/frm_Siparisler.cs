using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomasyon_Analiz.Islemler
{
    public partial class frm_Siparisler : Form
    {
        public frm_Siparisler()
        {
            InitializeComponent();
        }

        private void frm_Siparisler_Load(object sender, EventArgs e)
        {
            label1.Text = Moduller.frm_Masalar.Masa;
        }
    }
}
