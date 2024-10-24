namespace SISWin1
{
    partial class FormUzmanSeansYonetimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSeanslar = new System.Windows.Forms.ComboBox();
            this.grpHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDoğum = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpHastaGeçmişi = new System.Windows.Forms.GroupBox();
            this.txtGeçmişSeansNOtu = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lstSeanslar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSeansNotu = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAktifSeansNotu = new System.Windows.Forms.TextBox();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpHastaGeçmişi.SuspendLayout();
            this.grpSeansNotu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seanslar";
            // 
            // cbbSeanslar
            // 
            this.cbbSeanslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeanslar.FormattingEnabled = true;
            this.cbbSeanslar.Location = new System.Drawing.Point(114, 4);
            this.cbbSeanslar.Name = "cbbSeanslar";
            this.cbbSeanslar.Size = new System.Drawing.Size(121, 28);
            this.cbbSeanslar.TabIndex = 1;
            this.cbbSeanslar.SelectedIndexChanged += new System.EventHandler(this.cbbSeanslar_SelectedIndexChanged);
            // 
            // grpHastaBilgileri
            // 
            this.grpHastaBilgileri.Controls.Add(this.lblAdres);
            this.grpHastaBilgileri.Controls.Add(this.lblDoğum);
            this.grpHastaBilgileri.Controls.Add(this.lblGsm);
            this.grpHastaBilgileri.Controls.Add(this.lblTel);
            this.grpHastaBilgileri.Controls.Add(this.lblEposta);
            this.grpHastaBilgileri.Controls.Add(this.lblCinsiyet);
            this.grpHastaBilgileri.Controls.Add(this.lblSoyad);
            this.grpHastaBilgileri.Controls.Add(this.lblAd);
            this.grpHastaBilgileri.Controls.Add(this.lblTC);
            this.grpHastaBilgileri.Controls.Add(this.label11);
            this.grpHastaBilgileri.Controls.Add(this.label10);
            this.grpHastaBilgileri.Controls.Add(this.label9);
            this.grpHastaBilgileri.Controls.Add(this.label8);
            this.grpHastaBilgileri.Controls.Add(this.label7);
            this.grpHastaBilgileri.Controls.Add(this.label6);
            this.grpHastaBilgileri.Controls.Add(this.label5);
            this.grpHastaBilgileri.Controls.Add(this.label4);
            this.grpHastaBilgileri.Controls.Add(this.label3);
            this.grpHastaBilgileri.Location = new System.Drawing.Point(12, 53);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(266, 385);
            this.grpHastaBilgileri.TabIndex = 2;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblAdres
            // 
            this.lblAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdres.Location = new System.Drawing.Point(112, 241);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(132, 146);
            this.lblAdres.TabIndex = 17;
            // 
            // lblDoğum
            // 
            this.lblDoğum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoğum.Location = new System.Drawing.Point(144, 215);
            this.lblDoğum.Name = "lblDoğum";
            this.lblDoğum.Size = new System.Drawing.Size(100, 23);
            this.lblDoğum.TabIndex = 16;
            // 
            // lblGsm
            // 
            this.lblGsm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGsm.Location = new System.Drawing.Point(144, 188);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(100, 23);
            this.lblGsm.TabIndex = 15;
            // 
            // lblTel
            // 
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTel.Location = new System.Drawing.Point(144, 162);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 23);
            this.lblTel.TabIndex = 14;
            // 
            // lblEposta
            // 
            this.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEposta.Location = new System.Drawing.Point(144, 134);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(100, 23);
            this.lblEposta.TabIndex = 13;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCinsiyet.Location = new System.Drawing.Point(144, 109);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(100, 23);
            this.lblCinsiyet.TabIndex = 12;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoyad.Location = new System.Drawing.Point(144, 82);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(100, 23);
            this.lblSoyad.TabIndex = 11;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAd.Location = new System.Drawing.Point(144, 56);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(100, 23);
            this.lblAd.TabIndex = 10;
            // 
            // lblTC
            // 
            this.lblTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTC.Location = new System.Drawing.Point(144, 34);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(100, 23);
            this.lblTC.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Doğum Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "GSM No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Eposta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "TCKimlik No";
            // 
            // grpHastaGeçmişi
            // 
            this.grpHastaGeçmişi.Controls.Add(this.txtGeçmişSeansNOtu);
            this.grpHastaGeçmişi.Controls.Add(this.btnGuncelle);
            this.grpHastaGeçmişi.Controls.Add(this.lstSeanslar);
            this.grpHastaGeçmişi.Controls.Add(this.label2);
            this.grpHastaGeçmişi.Location = new System.Drawing.Point(284, 62);
            this.grpHastaGeçmişi.Name = "grpHastaGeçmişi";
            this.grpHastaGeçmişi.Size = new System.Drawing.Size(246, 376);
            this.grpHastaGeçmişi.TabIndex = 3;
            this.grpHastaGeçmişi.TabStop = false;
            this.grpHastaGeçmişi.Text = "Hasta Geçmişi";
            // 
            // txtGeçmişSeansNOtu
            // 
            this.txtGeçmişSeansNOtu.Location = new System.Drawing.Point(11, 181);
            this.txtGeçmişSeansNOtu.Multiline = true;
            this.txtGeçmişSeansNOtu.Name = "txtGeçmişSeansNOtu";
            this.txtGeçmişSeansNOtu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeçmişSeansNOtu.Size = new System.Drawing.Size(223, 143);
            this.txtGeçmişSeansNOtu.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(124, 330);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 28);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lstSeanslar
            // 
            this.lstSeanslar.FormattingEnabled = true;
            this.lstSeanslar.ItemHeight = 20;
            this.lstSeanslar.Location = new System.Drawing.Point(11, 50);
            this.lstSeanslar.Name = "lstSeanslar";
            this.lstSeanslar.ScrollAlwaysVisible = true;
            this.lstSeanslar.Size = new System.Drawing.Size(229, 124);
            this.lstSeanslar.TabIndex = 1;
            this.lstSeanslar.SelectedIndexChanged += new System.EventHandler(this.lstSeanslar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seanslar";
            // 
            // grpSeansNotu
            // 
            this.grpSeansNotu.Controls.Add(this.btnKaydet);
            this.grpSeansNotu.Controls.Add(this.txtAktifSeansNotu);
            this.grpSeansNotu.Location = new System.Drawing.Point(536, 62);
            this.grpSeansNotu.Name = "grpSeansNotu";
            this.grpSeansNotu.Size = new System.Drawing.Size(252, 376);
            this.grpSeansNotu.TabIndex = 4;
            this.grpSeansNotu.TabStop = false;
            this.grpSeansNotu.Text = "Seans Notu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 330);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 29);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAktifSeansNotu
            // 
            this.txtAktifSeansNotu.Location = new System.Drawing.Point(7, 26);
            this.txtAktifSeansNotu.Multiline = true;
            this.txtAktifSeansNotu.Name = "txtAktifSeansNotu";
            this.txtAktifSeansNotu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAktifSeansNotu.Size = new System.Drawing.Size(237, 298);
            this.txtAktifSeansNotu.TabIndex = 0;
            // 
            // FormUzmanSeansYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSeansNotu);
            this.Controls.Add(this.grpHastaGeçmişi);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.cbbSeanslar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUzmanSeansYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzman Seans Yönetimi";
            this.Load += new System.EventHandler(this.FormUzmanSeansYonetimi_Load);
            this.grpHastaBilgileri.ResumeLayout(false);
            this.grpHastaBilgileri.PerformLayout();
            this.grpHastaGeçmişi.ResumeLayout(false);
            this.grpHastaGeçmişi.PerformLayout();
            this.grpSeansNotu.ResumeLayout(false);
            this.grpSeansNotu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSeanslar;
        private System.Windows.Forms.GroupBox grpHastaBilgileri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpHastaGeçmişi;
        private System.Windows.Forms.TextBox txtGeçmişSeansNOtu;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ListBox lstSeanslar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSeansNotu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAktifSeansNotu;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDoğum;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
    }
}