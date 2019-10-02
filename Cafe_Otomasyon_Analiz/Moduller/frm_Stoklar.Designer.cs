namespace Cafe_Otomasyon_Analiz.Moduller
{
    partial class frm_Stoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Stoklar));
            this.lst_Stoklar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_StokKodu = new System.Windows.Forms.TextBox();
            this.txt_StokAdi = new System.Windows.Forms.TextBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.cmb_StokTuru = new System.Windows.Forms.ComboBox();
            this.cmb_Birim = new System.Windows.Forms.ComboBox();
            this.dt_Etarih = new System.Windows.Forms.DateTimePicker();
            this.dt_Starih = new System.Windows.Forms.DateTimePicker();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOKKODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOKADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOKTURU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EKTARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONTARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lst_Stoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Stoklar
            // 
            this.lst_Stoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_Stoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.STOKKODU,
            this.STOKADI,
            this.STOKTURU,
            this.EKTARIH,
            this.SONTARIH,
            this.BIRIM,
            this.FIYAT});
            this.lst_Stoklar.Location = new System.Drawing.Point(66, 153);
            this.lst_Stoklar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lst_Stoklar.Name = "lst_Stoklar";
            this.lst_Stoklar.Size = new System.Drawing.Size(744, 189);
            this.lst_Stoklar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 6);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 422);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stok Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stok Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ek. Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Son K. Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Birim :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fiyat :";
            // 
            // txt_StokKodu
            // 
            this.txt_StokKodu.Location = new System.Drawing.Point(177, 32);
            this.txt_StokKodu.Name = "txt_StokKodu";
            this.txt_StokKodu.Size = new System.Drawing.Size(129, 21);
            this.txt_StokKodu.TabIndex = 4;
            // 
            // txt_StokAdi
            // 
            this.txt_StokAdi.Location = new System.Drawing.Point(177, 70);
            this.txt_StokAdi.Name = "txt_StokAdi";
            this.txt_StokAdi.Size = new System.Drawing.Size(129, 21);
            this.txt_StokAdi.TabIndex = 4;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(643, 35);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(75, 21);
            this.txt_Fiyat.TabIndex = 4;
            // 
            // cmb_StokTuru
            // 
            this.cmb_StokTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StokTuru.FormattingEnabled = true;
            this.cmb_StokTuru.Items.AddRange(new object[] {
            "Yiyecek",
            "İçecek",
            "Demirbaş"});
            this.cmb_StokTuru.Location = new System.Drawing.Point(178, 107);
            this.cmb_StokTuru.Name = "cmb_StokTuru";
            this.cmb_StokTuru.Size = new System.Drawing.Size(128, 23);
            this.cmb_StokTuru.TabIndex = 5;
            this.cmb_StokTuru.SelectedIndexChanged += new System.EventHandler(this.cmb_StokTuru_SelectedIndexChanged);
            // 
            // cmb_Birim
            // 
            this.cmb_Birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Birim.FormattingEnabled = true;
            this.cmb_Birim.Items.AddRange(new object[] {
            "Kilo",
            "Litre",
            "Adet",
            "Gram"});
            this.cmb_Birim.Location = new System.Drawing.Point(439, 108);
            this.cmb_Birim.Name = "cmb_Birim";
            this.cmb_Birim.Size = new System.Drawing.Size(129, 23);
            this.cmb_Birim.TabIndex = 6;
            // 
            // dt_Etarih
            // 
            this.dt_Etarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Etarih.Location = new System.Drawing.Point(439, 34);
            this.dt_Etarih.Name = "dt_Etarih";
            this.dt_Etarih.Size = new System.Drawing.Size(129, 21);
            this.dt_Etarih.TabIndex = 7;
            // 
            // dt_Starih
            // 
            this.dt_Starih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Starih.Location = new System.Drawing.Point(439, 68);
            this.dt_Starih.Name = "dt_Starih";
            this.dt_Starih.Size = new System.Drawing.Size(129, 21);
            this.dt_Starih.TabIndex = 7;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.Image")));
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guncelle.Location = new System.Drawing.Point(366, 361);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(119, 36);
            this.btn_Guncelle.TabIndex = 8;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Image")));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sil.Location = new System.Drawing.Point(535, 361);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(89, 36);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.UseVisualStyleBackColor = false;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Green;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Image")));
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ekle.Location = new System.Drawing.Point(224, 361);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(89, 36);
            this.btn_Ekle.TabIndex = 10;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // STOKKODU
            // 
            this.STOKKODU.DataPropertyName = "STOKKODU";
            this.STOKKODU.HeaderText = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            // 
            // STOKADI
            // 
            this.STOKADI.DataPropertyName = "STOKADI";
            this.STOKADI.HeaderText = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            // 
            // STOKTURU
            // 
            this.STOKTURU.DataPropertyName = "STOKTURU";
            this.STOKTURU.HeaderText = "STOKTURU";
            this.STOKTURU.Name = "STOKTURU";
            // 
            // EKTARIH
            // 
            this.EKTARIH.DataPropertyName = "EKTARIH";
            this.EKTARIH.HeaderText = "EKTARIH";
            this.EKTARIH.Name = "EKTARIH";
            // 
            // SONTARIH
            // 
            this.SONTARIH.DataPropertyName = "SONTARIH";
            this.SONTARIH.HeaderText = "SONTARIH";
            this.SONTARIH.Name = "SONTARIH";
            // 
            // BIRIM
            // 
            this.BIRIM.DataPropertyName = "BIRIM";
            this.BIRIM.HeaderText = "BIRIM";
            this.BIRIM.Name = "BIRIM";
            // 
            // FIYAT
            // 
            this.FIYAT.DataPropertyName = "FIYAT";
            this.FIYAT.HeaderText = "FIYAT";
            this.FIYAT.Name = "FIYAT";
            // 
            // frm_Stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 428);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dt_Starih);
            this.Controls.Add(this.dt_Etarih);
            this.Controls.Add(this.cmb_Birim);
            this.Controls.Add(this.cmb_StokTuru);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.txt_StokAdi);
            this.Controls.Add(this.txt_StokKodu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lst_Stoklar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Stoklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOKLAR";
            this.Load += new System.EventHandler(this.frm_Stoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_Stoklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lst_Stoklar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_StokKodu;
        private System.Windows.Forms.TextBox txt_StokAdi;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.ComboBox cmb_StokTuru;
        private System.Windows.Forms.ComboBox cmb_Birim;
        private System.Windows.Forms.DateTimePicker dt_Etarih;
        private System.Windows.Forms.DateTimePicker dt_Starih;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOKKODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOKADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOKTURU;
        private System.Windows.Forms.DataGridViewTextBoxColumn EKTARIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONTARIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIYAT;
    }
}