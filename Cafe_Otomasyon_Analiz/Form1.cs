using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomasyon_Analiz
{
    public partial class frm_AnaSayfa : Form
    {
        public frm_AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Urunler_Click(object sender, EventArgs e)
        {
            Moduller.frm_Urunler frm = new Moduller.frm_Urunler();
            frm.ShowDialog();
        }

        private void btn_Stoklar_Click(object sender, EventArgs e)
        {
            Moduller.frm_Stoklar frm = new Moduller.frm_Stoklar();
            frm.ShowDialog();
        }

        private void btn_Giderler_Click(object sender, EventArgs e)
        {
            Moduller.frm_Giderler frm = new Moduller.frm_Giderler();
            frm.ShowDialog();
        }

        private void btn_Hesap_Click(object sender, EventArgs e)
        {
            Moduller.frm_Hesaplar frm = new Moduller.frm_Hesaplar();
            frm.ShowDialog();
        }

        private void btn_Personeller_Click(object sender, EventArgs e)
        {
            Moduller.frm_Personeller frm = new Moduller.frm_Personeller();
            frm.ShowDialog();
        }

        private void btn_CokSatanlar_Click(object sender, EventArgs e)
        {
            Moduller.frm_CokSatanlar frm = new Moduller.frm_CokSatanlar();
            frm.ShowDialog();
        }

        private void btn_Satislar_Click(object sender, EventArgs e)
        {
            Moduller.frm_SonSatislar frm = new Moduller.frm_SonSatislar();
            frm.ShowDialog();
        }

        private void btn_Masalar_Click(object sender, EventArgs e)
        {
            Moduller.frm_Masalar frm = new Moduller.frm_Masalar();
            frm.ShowDialog();
        }

        private void btn_Analizler_Click(object sender, EventArgs e)
        {
            Moduller.frm_Analizler frm = new Moduller.frm_Analizler();
            frm.ShowDialog();
        }
    }
}
