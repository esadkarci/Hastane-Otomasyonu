namespace SISWin1
{
    partial class FormHastaRandevuYonet
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
            this.grpArama = new System.Windows.Forms.GroupBox();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkYeniHastaGir = new System.Windows.Forms.LinkLabel();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDoğum = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpRandevuBilgileri = new System.Windows.Forms.GroupBox();
            this.lblRandevuSeans = new System.Windows.Forms.Label();
            this.lblSeansNot = new System.Windows.Forms.Label();
            this.lblSeansSeans = new System.Windows.Forms.Label();
            this.lblSeansUzman = new System.Windows.Forms.Label();
            this.lblRandevuUzman = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lnkRandevuİptalEt = new System.Windows.Forms.LinkLabel();
            this.lnkYeniRandevu = new System.Windows.Forms.LinkLabel();
            this.grpArama.SuspendLayout();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpRandevuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.lstHastalar);
            this.grpArama.Controls.Add(this.label3);
            this.grpArama.Controls.Add(this.lnkYeniHastaGir);
            this.grpArama.Controls.Add(this.btnAra);
            this.grpArama.Controls.Add(this.txtSoyad);
            this.grpArama.Controls.Add(this.txtAd);
            this.grpArama.Controls.Add(this.label2);
            this.grpArama.Controls.Add(this.label1);
            this.grpArama.Location = new System.Drawing.Point(12, 12);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(265, 426);
            this.grpArama.TabIndex = 0;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama";
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.ItemHeight = 20;
            this.lstHastalar.Location = new System.Drawing.Point(15, 232);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.ScrollAlwaysVisible = true;
            this.lstHastalar.Size = new System.Drawing.Size(229, 184);
            this.lstHastalar.TabIndex = 7;
            this.lstHastalar.SelectedIndexChanged += new System.EventHandler(this.lstHastalar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hastalar";
            // 
            // lnkYeniHastaGir
            // 
            this.lnkYeniHastaGir.AutoSize = true;
            this.lnkYeniHastaGir.Location = new System.Drawing.Point(132, 181);
            this.lnkYeniHastaGir.Name = "lnkYeniHastaGir";
            this.lnkYeniHastaGir.Size = new System.Drawing.Size(127, 20);
            this.lnkYeniHastaGir.TabIndex = 5;
            this.lnkYeniHastaGir.TabStop = true;
            this.lnkYeniHastaGir.Text = "Yeni Hasta Girişi";
            this.lnkYeniHastaGir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYeniHastaGir_LinkClicked);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(143, 122);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 36);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(128, 70);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(128, 33);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // grpHastaBilgileri
            // 
            this.grpHastaBilgileri.Controls.Add(this.lblAdres);
            this.grpHastaBilgileri.Controls.Add(this.lblGsm);
            this.grpHastaBilgileri.Controls.Add(this.lblTelefon);
            this.grpHastaBilgileri.Controls.Add(this.lblEposta);
            this.grpHastaBilgileri.Controls.Add(this.lblCinsiyet);
            this.grpHastaBilgileri.Controls.Add(this.lblDoğum);
            this.grpHastaBilgileri.Controls.Add(this.lblSoyad);
            this.grpHastaBilgileri.Controls.Add(this.lblAd);
            this.grpHastaBilgileri.Controls.Add(this.lblTC);
            this.grpHastaBilgileri.Controls.Add(this.label12);
            this.grpHastaBilgileri.Controls.Add(this.label11);
            this.grpHastaBilgileri.Controls.Add(this.label10);
            this.grpHastaBilgileri.Controls.Add(this.label9);
            this.grpHastaBilgileri.Controls.Add(this.label8);
            this.grpHastaBilgileri.Controls.Add(this.label7);
            this.grpHastaBilgileri.Controls.Add(this.label6);
            this.grpHastaBilgileri.Controls.Add(this.label5);
            this.grpHastaBilgileri.Controls.Add(this.label4);
            this.grpHastaBilgileri.Controls.Add(this.linkLabel1);
            this.grpHastaBilgileri.Location = new System.Drawing.Point(283, 12);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(252, 426);
            this.grpHastaBilgileri.TabIndex = 1;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblAdres
            // 
            this.lblAdres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdres.Location = new System.Drawing.Point(119, 270);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(127, 146);
            this.lblAdres.TabIndex = 18;
            // 
            // lblGsm
            // 
            this.lblGsm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGsm.Location = new System.Drawing.Point(119, 248);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(100, 23);
            this.lblGsm.TabIndex = 17;
            // 
            // lblTelefon
            // 
            this.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefon.Location = new System.Drawing.Point(119, 219);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(100, 23);
            this.lblTelefon.TabIndex = 16;
            // 
            // lblEposta
            // 
            this.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEposta.Location = new System.Drawing.Point(119, 192);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(100, 23);
            this.lblEposta.TabIndex = 15;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCinsiyet.Location = new System.Drawing.Point(119, 163);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(100, 23);
            this.lblCinsiyet.TabIndex = 14;
            // 
            // lblDoğum
            // 
            this.lblDoğum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoğum.Location = new System.Drawing.Point(119, 137);
            this.lblDoğum.Name = "lblDoğum";
            this.lblDoğum.Size = new System.Drawing.Size(100, 23);
            this.lblDoğum.TabIndex = 13;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoyad.Location = new System.Drawing.Point(119, 105);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(100, 23);
            this.lblSoyad.TabIndex = 12;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAd.Location = new System.Drawing.Point(119, 74);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(100, 23);
            this.lblAd.TabIndex = 11;
            // 
            // lblTC
            // 
            this.lblTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTC.Location = new System.Drawing.Point(119, 46);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(100, 23);
            this.lblTC.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Gsm No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Eposta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "TCKimlikNO";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(68, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hasta Bilgilerini Güncelle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // grpRandevuBilgileri
            // 
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuSeans);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansNot);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansSeans);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansUzman);
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuUzman);
            this.grpRandevuBilgileri.Controls.Add(this.label19);
            this.grpRandevuBilgileri.Controls.Add(this.label18);
            this.grpRandevuBilgileri.Controls.Add(this.label17);
            this.grpRandevuBilgileri.Controls.Add(this.label16);
            this.grpRandevuBilgileri.Controls.Add(this.label15);
            this.grpRandevuBilgileri.Controls.Add(this.label14);
            this.grpRandevuBilgileri.Controls.Add(this.label13);
            this.grpRandevuBilgileri.Controls.Add(this.lnkRandevuİptalEt);
            this.grpRandevuBilgileri.Controls.Add(this.lnkYeniRandevu);
            this.grpRandevuBilgileri.Location = new System.Drawing.Point(541, 12);
            this.grpRandevuBilgileri.Name = "grpRandevuBilgileri";
            this.grpRandevuBilgileri.Size = new System.Drawing.Size(261, 426);
            this.grpRandevuBilgileri.TabIndex = 2;
            this.grpRandevuBilgileri.TabStop = false;
            this.grpRandevuBilgileri.Text = "Randevu Bilgileri";
            // 
            // lblRandevuSeans
            // 
            this.lblRandevuSeans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandevuSeans.Location = new System.Drawing.Point(107, 107);
            this.lblRandevuSeans.Name = "lblRandevuSeans";
            this.lblRandevuSeans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRandevuSeans.Size = new System.Drawing.Size(100, 23);
            this.lblRandevuSeans.TabIndex = 13;
            // 
            // lblSeansNot
            // 
            this.lblSeansNot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeansNot.Location = new System.Drawing.Point(107, 302);
            this.lblSeansNot.Name = "lblSeansNot";
            this.lblSeansNot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSeansNot.Size = new System.Drawing.Size(141, 114);
            this.lblSeansNot.TabIndex = 12;
            // 
            // lblSeansSeans
            // 
            this.lblSeansSeans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeansSeans.Location = new System.Drawing.Point(107, 269);
            this.lblSeansSeans.Name = "lblSeansSeans";
            this.lblSeansSeans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSeansSeans.Size = new System.Drawing.Size(100, 23);
            this.lblSeansSeans.TabIndex = 11;
            // 
            // lblSeansUzman
            // 
            this.lblSeansUzman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeansUzman.Location = new System.Drawing.Point(107, 231);
            this.lblSeansUzman.Name = "lblSeansUzman";
            this.lblSeansUzman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSeansUzman.Size = new System.Drawing.Size(100, 23);
            this.lblSeansUzman.TabIndex = 10;
            // 
            // lblRandevuUzman
            // 
            this.lblRandevuUzman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandevuUzman.Location = new System.Drawing.Point(107, 74);
            this.lblRandevuUzman.Name = "lblRandevuUzman";
            this.lblRandevuUzman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRandevuUzman.Size = new System.Drawing.Size(100, 23);
            this.lblRandevuUzman.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Not";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Seans";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Uzman";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Seans";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Uzman";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Son Seans Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Son Randevu Bilgileri";
            // 
            // lnkRandevuİptalEt
            // 
            this.lnkRandevuİptalEt.AutoSize = true;
            this.lnkRandevuİptalEt.Location = new System.Drawing.Point(120, 163);
            this.lnkRandevuİptalEt.Name = "lnkRandevuİptalEt";
            this.lnkRandevuİptalEt.Size = new System.Drawing.Size(128, 20);
            this.lnkRandevuİptalEt.TabIndex = 1;
            this.lnkRandevuİptalEt.TabStop = true;
            this.lnkRandevuİptalEt.Text = "Randevu İptal Et";
            this.lnkRandevuİptalEt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRandevuİptalEt_LinkClicked);
            // 
            // lnkYeniRandevu
            // 
            this.lnkYeniRandevu.AutoSize = true;
            this.lnkYeniRandevu.Location = new System.Drawing.Point(138, 22);
            this.lnkYeniRandevu.Name = "lnkYeniRandevu";
            this.lnkYeniRandevu.Size = new System.Drawing.Size(109, 20);
            this.lnkYeniRandevu.TabIndex = 0;
            this.lnkYeniRandevu.TabStop = true;
            this.lnkYeniRandevu.Text = "Yeni Randevu";
            this.lnkYeniRandevu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYeniRandevu_LinkClicked);
            // 
            // FormHastaRandevuYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRandevuBilgileri);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.grpArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHastaRandevuYonet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta ve Randevu Yönetimi";
            this.Load += new System.EventHandler(this.FormHastaRandevuYonet_Load);
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.grpHastaBilgileri.ResumeLayout(false);
            this.grpHastaBilgileri.PerformLayout();
            this.grpRandevuBilgileri.ResumeLayout(false);
            this.grpRandevuBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArama;
        private System.Windows.Forms.GroupBox grpHastaBilgileri;
        private System.Windows.Forms.GroupBox grpRandevuBilgileri;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkYeniHastaGir;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblDoğum;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblRandevuSeans;
        private System.Windows.Forms.Label lblSeansNot;
        private System.Windows.Forms.Label lblSeansSeans;
        private System.Windows.Forms.Label lblSeansUzman;
        private System.Windows.Forms.Label lblRandevuUzman;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel lnkRandevuİptalEt;
        private System.Windows.Forms.LinkLabel lnkYeniRandevu;
    }
}