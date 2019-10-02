using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Otomasyon_Analiz.Moduller
{
    public partial class frm_Urunler : Form
    {
        public frm_Urunler()
        {
            InitializeComponent();
        }
        OpenFileDialog Dosya = new OpenFileDialog();
        Islemler.DataBase1DataContext DB = new Islemler.DataBase1DataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Resim = false;
        void ResimSec()
            
        {
            Dosya.Filter = "Jpeg(*.jpg)|*.jpg|Jpeg(*.Jpeg)|*.Jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                ResimKutusu.ImageLocation = Dosya.FileName;
                Resim = true;

            }
        }
        private void frm_Urunler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Ekle()
        {
            Islemler.URUNLER Urunler = new Islemler.URUNLER();
            Urunler.ACIKLAMA = txt_Aciklama.Text;
            Urunler.EKTARIH = Convert.ToDateTime(dt_Etarih.Text);
            Urunler.FIYAT = txt_Fiyat.Text;
            Urunler.TUR = cmb_Tur.Text;
            Urunler.URUNADI = txt_UrunAdi.Text;
            DB.URUNLERs.InsertOnSubmit(Urunler);
            DB.SubmitChanges();
            Temizle();
            
 
        }
        void Temizle()
        {
            txt_UrunAdi.Text = "";
            txt_Fiyat.Text = "";
            txt_Aciklama.Text = "";
        }
        void Listele()
        {
            var lst = from s in DB.URUNLERs
                      select s;
            lst_Urunler.DataSource = lst;
            
        }

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_Aciklama.Text != "" && txt_Fiyat.Text != "" && txt_UrunAdi.Text != "")
            {
                Ekle();
                Mesajlar.YeniKayit(Mesaj:"Yeni Kayıt!");
            }
            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

        }


    }
}
