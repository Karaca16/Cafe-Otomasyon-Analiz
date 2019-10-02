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
    public partial class frm_Stoklar : Form
    {
        public frm_Stoklar()
        {
            InitializeComponent();
        }
        Islemler.DataBase1DataContext DB = new Islemler.DataBase1DataContext();
        private void frm_Stoklar_Load(object sender, EventArgs e)
        {
            txt_StokKodu.Text = "S_000001";
            Listele();
        }
        void Ekle()
        {
            try
            {
                Islemler.STOKLAR Stoklar = new Islemler.STOKLAR();
                Stoklar.BIRIM = cmb_Birim.Text;
                Stoklar.EKTARIH = Convert.ToDateTime(dt_Etarih.Text);
                Stoklar.FIYAT = txt_Fiyat.Text;
                Stoklar.SONTARIH = Convert.ToDateTime(dt_Etarih.Text);
                Stoklar.STOKADI = txt_StokAdi.Text;
                Stoklar.STOKKODU = txt_StokKodu.Text;
                Stoklar.STOKTURU = cmb_StokTuru.Text;
                DB.STOKLARs.InsertOnSubmit(Stoklar);
                DB.SubmitChanges();
                Temizle();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!");
            }
        }
        void Sil()
        { }
        void Güncelle()
        { }
        void Temizle()
        {
            txt_StokKodu.Text = "";
            txt_StokAdi.Text = "";
            txt_Fiyat.Text = "";
            cmb_Birim.Text = "";
            cmb_StokTuru.Text = "";
        }
        void Listele()
        {
            var listele = from s in DB.STOKLARs
                          select s;
            lst_Stoklar.DataSource = listele;
        }
        private void cmb_StokTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_StokTuru.SelectedIndex == 0) //Yiyecek
            {
                cmb_Birim.Items.Clear();
                cmb_Birim.Items.Add("Kilo");
                cmb_Birim.Items.Add("Adet");
                cmb_Birim.Items.Add("Gram");
                dt_Starih.Enabled = true;
            }
            else if (cmb_StokTuru.SelectedIndex == 1) //İçecek
            {
                cmb_Birim.Items.Clear();
                cmb_Birim.Items.Add("Litre");
                cmb_Birim.Items.Add("M.Litre");
                dt_Starih.Enabled = true;
            }
            else if (cmb_StokTuru.SelectedIndex == 2)//Demirbaş
            {
                cmb_Birim.Items.Clear();
                cmb_Birim.Items.Add("Adet");
                dt_Starih.Enabled = false;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_StokKodu.Text !="" && txt_StokAdi.Text != "" && txt_Fiyat.Text != "" && cmb_Birim.Text !="" && cmb_StokTuru.Text != "")
            {
                Ekle();
                MessageBox.Show("Ekleme İşlemi Başarıyla Yapıldı!");
            }
            else
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır!");
            }
            
        }

       
    }
}
