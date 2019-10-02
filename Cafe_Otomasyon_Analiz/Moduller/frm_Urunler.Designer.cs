namespace Cafe_Otomasyon_Analiz.Moduller
{
    partial class frm_Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Urunler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.cmb_Tur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_Etarih = new System.Windows.Forms.DateTimePicker();
            this.lst_Urunler = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ResimKutusu = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btn_ResimSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lst_Urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tür :";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(148, 20);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(130, 21);
            this.txt_UrunAdi.TabIndex = 1;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(436, 20);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(130, 21);
            this.txt_Fiyat.TabIndex = 2;
            // 
            // cmb_Tur
            // 
            this.cmb_Tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tur.FormattingEnabled = true;
            this.cmb_Tur.Items.AddRange(new object[] {
            "Çaylar",
            "Kahveler",
            "Tatlılar",
            "Çorbalar",
            "Gazlı İçecekler"});
            this.cmb_Tur.Location = new System.Drawing.Point(148, 51);
            this.cmb_Tur.Name = "cmb_Tur";
            this.cmb_Tur.Size = new System.Drawing.Size(130, 23);
            this.cmb_Tur.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ek. Tarih :";
            // 
            // dt_Etarih
            // 
            this.dt_Etarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Etarih.Location = new System.Drawing.Point(436, 53);
            this.dt_Etarih.Name = "dt_Etarih";
            this.dt_Etarih.Size = new System.Drawing.Size(130, 21);
            this.dt_Etarih.TabIndex = 5;
            // 
            // lst_Urunler
            // 
            this.lst_Urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_Urunler.Location = new System.Drawing.Point(68, 185);
            this.lst_Urunler.Name = "lst_Urunler";
            this.lst_Urunler.Size = new System.Drawing.Size(686, 181);
            this.lst_Urunler.TabIndex = 6;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Green;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Image")));
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ekle.Location = new System.Drawing.Point(221, 389);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(89, 36);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.Location = new System.Drawing.Point(518, 389);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(89, 36);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.Image")));
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guncelle.Location = new System.Drawing.Point(357, 389);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(119, 36);
            this.btn_Guncelle.TabIndex = 7;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 5);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 447);
            this.panel2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Resim :";
            // 
            // ResimKutusu
            // 
            this.ResimKutusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResimKutusu.Location = new System.Drawing.Point(148, 80);
            this.ResimKutusu.Name = "ResimKutusu";
            this.ResimKutusu.Size = new System.Drawing.Size(130, 85);
            this.ResimKutusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResimKutusu.TabIndex = 11;
            this.ResimKutusu.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Açıklama :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(436, 84);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(236, 81);
            this.txt_Aciklama.TabIndex = 12;
            // 
            // btn_ResimSec
            // 
            this.btn_ResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResimSec.Location = new System.Drawing.Point(284, 120);
            this.btn_ResimSec.Name = "btn_ResimSec";
            this.btn_ResimSec.Size = new System.Drawing.Size(46, 45);
            this.btn_ResimSec.TabIndex = 13;
            this.btn_ResimSec.Text = "Resim Sec";
            this.btn_ResimSec.UseVisualStyleBackColor = true;
            this.btn_ResimSec.Click += new System.EventHandler(this.btn_ResimSec_Click);
            // 
            // frm_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Controls.Add(this.btn_ResimSec);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.ResimKutusu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.lst_Urunler);
            this.Controls.Add(this.dt_Etarih);
            this.Controls.Add(this.cmb_Tur);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.frm_Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_Urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.ComboBox cmb_Tur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_Etarih;
        private System.Windows.Forms.DataGridView lst_Urunler;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ResimKutusu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_ResimSec;
    }
}