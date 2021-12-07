namespace CRM_Example
{
    partial class Form1
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
            this.grdMusteriler = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.txtVKN = new System.Windows.Forms.TextBox();
            this.txtSirketAdresi = new System.Windows.Forms.TextBox();
            this.txtYillikCiro = new System.Windows.Forms.TextBox();
            this.txtSektor = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.syad = new System.Windows.Forms.Label();
            this.irthDate = new System.Windows.Forms.Label();
            this.CKo = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.grbMusteri = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
            this.grbMusteri.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMusteriler
            // 
            this.grdMusteriler.AllowUserToAddRows = false;
            this.grdMusteriler.AllowUserToDeleteRows = false;
            this.grdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMusteriler.Location = new System.Drawing.Point(327, 12);
            this.grdMusteriler.MultiSelect = false;
            this.grdMusteriler.Name = "grdMusteriler";
            this.grdMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMusteriler.Size = new System.Drawing.Size(704, 397);
            this.grdMusteriler.TabIndex = 0;
            this.grdMusteriler.DoubleClick += new System.EventHandler(this.grdPersonel_DoubleClick);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(197, 20);
            this.txtAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 14);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 25);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(197, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(94, 99);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.Size = new System.Drawing.Size(197, 20);
            this.txtTCKNo.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 126);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(197, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(94, 153);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(197, 20);
            this.txtMail.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 180);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(197, 20);
            this.txtAdres.TabIndex = 1;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(94, 207);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(197, 20);
            this.txtSirketAdi.TabIndex = 1;
            // 
            // txtVKN
            // 
            this.txtVKN.Location = new System.Drawing.Point(94, 234);
            this.txtVKN.Name = "txtVKN";
            this.txtVKN.Size = new System.Drawing.Size(197, 20);
            this.txtVKN.TabIndex = 1;
            // 
            // txtSirketAdresi
            // 
            this.txtSirketAdresi.Location = new System.Drawing.Point(94, 261);
            this.txtSirketAdresi.Name = "txtSirketAdresi";
            this.txtSirketAdresi.Size = new System.Drawing.Size(197, 20);
            this.txtSirketAdresi.TabIndex = 1;
            // 
            // txtYillikCiro
            // 
            this.txtYillikCiro.Location = new System.Drawing.Point(94, 288);
            this.txtYillikCiro.Name = "txtYillikCiro";
            this.txtYillikCiro.Size = new System.Drawing.Size(197, 20);
            this.txtYillikCiro.TabIndex = 1;
            // 
            // txtSektor
            // 
            this.txtSektor.Location = new System.Drawing.Point(94, 315);
            this.txtSektor.Name = "txtSektor";
            this.txtSektor.Size = new System.Drawing.Size(197, 20);
            this.txtSektor.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(18, 21);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // syad
            // 
            this.syad.AutoSize = true;
            this.syad.Location = new System.Drawing.Point(18, 48);
            this.syad.Name = "syad";
            this.syad.Size = new System.Drawing.Size(37, 13);
            this.syad.TabIndex = 3;
            this.syad.Text = "Soyad";
            // 
            // irthDate
            // 
            this.irthDate.AutoSize = true;
            this.irthDate.Location = new System.Drawing.Point(18, 75);
            this.irthDate.Name = "irthDate";
            this.irthDate.Size = new System.Drawing.Size(70, 13);
            this.irthDate.TabIndex = 3;
            this.irthDate.Text = "Doğum Tarihi";
            // 
            // CKo
            // 
            this.CKo.AutoSize = true;
            this.CKo.Location = new System.Drawing.Point(18, 102);
            this.CKo.Name = "CKo";
            this.CKo.Size = new System.Drawing.Size(42, 13);
            this.CKo.TabIndex = 3;
            this.CKo.Text = "TCKNo";
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(18, 129);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 3;
            this.Telefon.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Şirket Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "VKN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Şirket Adresi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Yıllık Ciro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Sektör";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(94, 72);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(197, 20);
            this.dtpBirthDate.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(111, 14);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 25);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(204, 14);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(87, 25);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // grbMusteri
            // 
            this.grbMusteri.BackColor = System.Drawing.Color.Moccasin;
            this.grbMusteri.Controls.Add(this.panel1);
            this.grbMusteri.Controls.Add(this.CKo);
            this.grbMusteri.Controls.Add(this.txtAd);
            this.grbMusteri.Controls.Add(this.txtSoyad);
            this.grbMusteri.Controls.Add(this.dtpBirthDate);
            this.grbMusteri.Controls.Add(this.txtTelefon);
            this.grbMusteri.Controls.Add(this.label12);
            this.grbMusteri.Controls.Add(this.txtVKN);
            this.grbMusteri.Controls.Add(this.label11);
            this.grbMusteri.Controls.Add(this.txtMail);
            this.grbMusteri.Controls.Add(this.label8);
            this.grbMusteri.Controls.Add(this.txtTCKNo);
            this.grbMusteri.Controls.Add(this.label7);
            this.grbMusteri.Controls.Add(this.txtSirketAdresi);
            this.grbMusteri.Controls.Add(this.label10);
            this.grbMusteri.Controls.Add(this.txtAdres);
            this.grbMusteri.Controls.Add(this.txtSirketAdi);
            this.grbMusteri.Controls.Add(this.label6);
            this.grbMusteri.Controls.Add(this.txtYillikCiro);
            this.grbMusteri.Controls.Add(this.label9);
            this.grbMusteri.Controls.Add(this.txtSektor);
            this.grbMusteri.Controls.Add(this.irthDate);
            this.grbMusteri.Controls.Add(this.Telefon);
            this.grbMusteri.Controls.Add(this.lblAd);
            this.grbMusteri.Controls.Add(this.syad);
            this.grbMusteri.Location = new System.Drawing.Point(12, 12);
            this.grbMusteri.Name = "grbMusteri";
            this.grbMusteri.Size = new System.Drawing.Size(312, 397);
            this.grbMusteri.TabIndex = 7;
            this.grbMusteri.TabStop = false;
            this.grbMusteri.Text = "Müşteri Bilgileri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 53);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1043, 424);
            this.Controls.Add(this.grbMusteri);
            this.Controls.Add(this.grdMusteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CRM v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
            this.grbMusteri.ResumeLayout(false);
            this.grbMusteri.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMusteriler;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.TextBox txtVKN;
        private System.Windows.Forms.TextBox txtSirketAdresi;
        private System.Windows.Forms.TextBox txtYillikCiro;
        private System.Windows.Forms.TextBox txtSektor;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label syad;
        private System.Windows.Forms.Label irthDate;
        private System.Windows.Forms.Label CKo;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.GroupBox grbMusteri;
        private System.Windows.Forms.Panel panel1;
    }
}

