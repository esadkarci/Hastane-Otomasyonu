namespace SISWin
{
    partial class FormUzmanSeansYönetim
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
            this.grpHastaGeçmişi = new System.Windows.Forms.GroupBox();
            this.grpSeansNotu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblGSM = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDoğumTarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstSeanslarr = new System.Windows.Forms.ListBox();
            this.txtGeçmişSeansNotu = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAktifSeansNotu = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpHastaGeçmişi.SuspendLayout();
            this.grpSeansNotu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seanslar:";
            // 
            // cbbSeanslar
            // 
            this.cbbSeanslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeanslar.FormattingEnabled = true;
            this.cbbSeanslar.Location = new System.Drawing.Point(107, 11);
            this.cbbSeanslar.Name = "cbbSeanslar";
            this.cbbSeanslar.Size = new System.Drawing.Size(182, 33);
            this.cbbSeanslar.TabIndex = 1;
            // 
            // grpHastaBilgileri
            // 
            this.grpHastaBilgileri.Controls.Add(this.lblAd);
            this.grpHastaBilgileri.Controls.Add(this.lblSoyad);
            this.grpHastaBilgileri.Controls.Add(this.lblDoğumTarihi);
            this.grpHastaBilgileri.Controls.Add(this.lblCinsiyet);
            this.grpHastaBilgileri.Controls.Add(this.lblEposta);
            this.grpHastaBilgileri.Controls.Add(this.lblTelefon);
            this.grpHastaBilgileri.Controls.Add(this.lblGSM);
            this.grpHastaBilgileri.Controls.Add(this.lblAdres);
            this.grpHastaBilgileri.Controls.Add(this.lblTC);
            this.grpHastaBilgileri.Controls.Add(this.label10);
            this.grpHastaBilgileri.Controls.Add(this.label9);
            this.grpHastaBilgileri.Controls.Add(this.label8);
            this.grpHastaBilgileri.Controls.Add(this.label7);
            this.grpHastaBilgileri.Controls.Add(this.label6);
            this.grpHastaBilgileri.Controls.Add(this.label5);
            this.grpHastaBilgileri.Controls.Add(this.label4);
            this.grpHastaBilgileri.Controls.Add(this.label3);
            this.grpHastaBilgileri.Controls.Add(this.label2);
            this.grpHastaBilgileri.Location = new System.Drawing.Point(12, 50);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(360, 571);
            this.grpHastaBilgileri.TabIndex = 2;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // grpHastaGeçmişi
            // 
            this.grpHastaGeçmişi.Controls.Add(this.btnGuncelle);
            this.grpHastaGeçmişi.Controls.Add(this.txtGeçmişSeansNotu);
            this.grpHastaGeçmişi.Controls.Add(this.lstSeanslarr);
            this.grpHastaGeçmişi.Controls.Add(this.label11);
            this.grpHastaGeçmişi.Location = new System.Drawing.Point(378, 50);
            this.grpHastaGeçmişi.Name = "grpHastaGeçmişi";
            this.grpHastaGeçmişi.Size = new System.Drawing.Size(345, 571);
            this.grpHastaGeçmişi.TabIndex = 3;
            this.grpHastaGeçmişi.TabStop = false;
            this.grpHastaGeçmişi.Text = "Hasta Geçmişi";
            // 
            // grpSeansNotu
            // 
            this.grpSeansNotu.Controls.Add(this.btnKaydet);
            this.grpSeansNotu.Controls.Add(this.txtAktifSeansNotu);
            this.grpSeansNotu.Location = new System.Drawing.Point(729, 63);
            this.grpSeansNotu.Name = "grpSeansNotu";
            this.grpSeansNotu.Size = new System.Drawing.Size(324, 558);
            this.grpSeansNotu.TabIndex = 4;
            this.grpSeansNotu.TabStop = false;
            this.grpSeansNotu.Text = "Seans Notu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "T.C. Kimlik Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-posta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(2, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Soyad:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(2, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(2, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefon Numarası:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(2, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "GSM Numarası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(2, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Adres:";
            // 
            // lblTC
            // 
            this.lblTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTC.Location = new System.Drawing.Point(193, 55);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(145, 25);
            this.lblTC.TabIndex = 9;
            // 
            // lblAdres
            // 
            this.lblAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdres.Location = new System.Drawing.Point(191, 254);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(145, 235);
            this.lblAdres.TabIndex = 13;
            // 
            // lblGSM
            // 
            this.lblGSM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGSM.Location = new System.Drawing.Point(191, 230);
            this.lblGSM.Name = "lblGSM";
            this.lblGSM.Size = new System.Drawing.Size(145, 25);
            this.lblGSM.TabIndex = 14;
            // 
            // lblTelefon
            // 
            this.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefon.Location = new System.Drawing.Point(191, 205);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(145, 25);
            this.lblTelefon.TabIndex = 15;
            // 
            // lblEposta
            // 
            this.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEposta.Location = new System.Drawing.Point(191, 180);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(145, 25);
            this.lblEposta.TabIndex = 16;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCinsiyet.Location = new System.Drawing.Point(192, 154);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(145, 25);
            this.lblCinsiyet.TabIndex = 17;
            this.lblCinsiyet.Click += new System.EventHandler(this.label18_Click);
            // 
            // lblDoğumTarihi
            // 
            this.lblDoğumTarihi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoğumTarihi.Location = new System.Drawing.Point(192, 130);
            this.lblDoğumTarihi.Name = "lblDoğumTarihi";
            this.lblDoğumTarihi.Size = new System.Drawing.Size(145, 25);
            this.lblDoğumTarihi.TabIndex = 18;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoyad.Location = new System.Drawing.Point(192, 104);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(145, 25);
            this.lblSoyad.TabIndex = 19;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAd.Location = new System.Drawing.Point(192, 80);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(145, 25);
            this.lblAd.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Seansalar:";
            // 
            // lstSeanslarr
            // 
            this.lstSeanslarr.FormattingEnabled = true;
            this.lstSeanslarr.ItemHeight = 25;
            this.lstSeanslarr.Location = new System.Drawing.Point(18, 80);
            this.lstSeanslarr.Name = "lstSeanslarr";
            this.lstSeanslarr.ScrollAlwaysVisible = true;
            this.lstSeanslarr.Size = new System.Drawing.Size(321, 129);
            this.lstSeanslarr.TabIndex = 1;
            // 
            // txtGeçmişSeansNotu
            // 
            this.txtGeçmişSeansNotu.Location = new System.Drawing.Point(18, 215);
            this.txtGeçmişSeansNotu.Multiline = true;
            this.txtGeçmişSeansNotu.Name = "txtGeçmişSeansNotu";
            this.txtGeçmişSeansNotu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeçmişSeansNotu.Size = new System.Drawing.Size(321, 289);
            this.txtGeçmişSeansNotu.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(194, 510);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(137, 45);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtAktifSeansNotu
            // 
            this.txtAktifSeansNotu.Location = new System.Drawing.Point(8, 47);
            this.txtAktifSeansNotu.Multiline = true;
            this.txtAktifSeansNotu.Name = "txtAktifSeansNotu";
            this.txtAktifSeansNotu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAktifSeansNotu.Size = new System.Drawing.Size(310, 444);
            this.txtAktifSeansNotu.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(182, 497);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 45);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormUzmanSeansYönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 633);
            this.Controls.Add(this.grpSeansNotu);
            this.Controls.Add(this.grpHastaGeçmişi);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.cbbSeanslar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUzmanSeansYönetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzman Seans Yönetim";
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

        private Label label1;
        private ComboBox cbbSeanslar;
        private GroupBox grpHastaBilgileri;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox grpHastaGeçmişi;
        private GroupBox grpSeansNotu;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblDoğumTarihi;
        private Label lblCinsiyet;
        private Label lblEposta;
        private Label lblTelefon;
        private Label lblGSM;
        private Label lblAdres;
        private Label lblTC;
        private Button btnGuncelle;
        private TextBox txtGeçmişSeansNotu;
        private ListBox lstSeanslarr;
        private Label label11;
        private Button btnKaydet;
        private TextBox txtAktifSeansNotu;
    }
}