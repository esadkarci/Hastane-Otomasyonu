namespace SISWin
{
    partial class FormHastaveRandevuYönetimi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.grpRandevuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lnkYeniHastaGir = new System.Windows.Forms.LinkLabel();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lnkHastaGüncelle = new System.Windows.Forms.LinkLabel();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDoğumTarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblRandevuUzman = new System.Windows.Forms.Label();
            this.lblRandevuSeans = new System.Windows.Forms.Label();
            this.lblSeansUzman = new System.Windows.Forms.Label();
            this.lblSeansSeans = new System.Windows.Forms.Label();
            this.lblSeansNot = new System.Windows.Forms.Label();
            this.lnkYeniRandevu = new System.Windows.Forms.LinkLabel();
            this.lblRandevuyuİptalEt = new System.Windows.Forms.LinkLabel();
            this.grpArama.SuspendLayout();
            this.grpHastaBilgileri.SuspendLayout();
            this.grpRandevuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArama
            // 
            this.grpArama.Controls.Add(this.lstHastalar);
            this.grpArama.Controls.Add(this.lnkYeniHastaGir);
            this.grpArama.Controls.Add(this.txtSoyad);
            this.grpArama.Controls.Add(this.txtAd);
            this.grpArama.Controls.Add(this.btnAra);
            this.grpArama.Controls.Add(this.label3);
            this.grpArama.Controls.Add(this.label2);
            this.grpArama.Controls.Add(this.label1);
            this.grpArama.Location = new System.Drawing.Point(12, 1);
            this.grpArama.Name = "grpArama";
            this.grpArama.Size = new System.Drawing.Size(352, 625);
            this.grpArama.TabIndex = 0;
            this.grpArama.TabStop = false;
            this.grpArama.Text = "Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastalar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // grpHastaBilgileri
            // 
            this.grpHastaBilgileri.Controls.Add(this.lblAd);
            this.grpHastaBilgileri.Controls.Add(this.lblSoyad);
            this.grpHastaBilgileri.Controls.Add(this.lblDoğumTarihi);
            this.grpHastaBilgileri.Controls.Add(this.lblCinsiyet);
            this.grpHastaBilgileri.Controls.Add(this.lblEposta);
            this.grpHastaBilgileri.Controls.Add(this.lblTelefon);
            this.grpHastaBilgileri.Controls.Add(this.lblGsm);
            this.grpHastaBilgileri.Controls.Add(this.lblAdres);
            this.grpHastaBilgileri.Controls.Add(this.lblTC);
            this.grpHastaBilgileri.Controls.Add(this.lnkHastaGüncelle);
            this.grpHastaBilgileri.Controls.Add(this.label11);
            this.grpHastaBilgileri.Controls.Add(this.label10);
            this.grpHastaBilgileri.Controls.Add(this.label9);
            this.grpHastaBilgileri.Controls.Add(this.label7);
            this.grpHastaBilgileri.Controls.Add(this.label6);
            this.grpHastaBilgileri.Controls.Add(this.label5);
            this.grpHastaBilgileri.Controls.Add(this.label13);
            this.grpHastaBilgileri.Controls.Add(this.label8);
            this.grpHastaBilgileri.Controls.Add(this.label4);
            this.grpHastaBilgileri.Location = new System.Drawing.Point(370, 1);
            this.grpHastaBilgileri.Name = "grpHastaBilgileri";
            this.grpHastaBilgileri.Size = new System.Drawing.Size(333, 625);
            this.grpHastaBilgileri.TabIndex = 1;
            this.grpHastaBilgileri.TabStop = false;
            this.grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // grpRandevuBilgileri
            // 
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuyuİptalEt);
            this.grpRandevuBilgileri.Controls.Add(this.lnkYeniRandevu);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansNot);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansSeans);
            this.grpRandevuBilgileri.Controls.Add(this.lblSeansUzman);
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuSeans);
            this.grpRandevuBilgileri.Controls.Add(this.lblRandevuUzman);
            this.grpRandevuBilgileri.Controls.Add(this.label19);
            this.grpRandevuBilgileri.Controls.Add(this.label18);
            this.grpRandevuBilgileri.Controls.Add(this.label17);
            this.grpRandevuBilgileri.Controls.Add(this.label16);
            this.grpRandevuBilgileri.Controls.Add(this.label15);
            this.grpRandevuBilgileri.Controls.Add(this.label14);
            this.grpRandevuBilgileri.Controls.Add(this.label12);
            this.grpRandevuBilgileri.Location = new System.Drawing.Point(709, 1);
            this.grpRandevuBilgileri.Name = "grpRandevuBilgileri";
            this.grpRandevuBilgileri.Size = new System.Drawing.Size(352, 625);
            this.grpRandevuBilgileri.TabIndex = 2;
            this.grpRandevuBilgileri.TabStop = false;
            this.grpRandevuBilgileri.Text = "RandevuBilgileri";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(216, 177);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(107, 40);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(182, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 31);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(182, 103);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 31);
            this.txtSoyad.TabIndex = 5;
            // 
            // lnkYeniHastaGir
            // 
            this.lnkYeniHastaGir.AutoSize = true;
            this.lnkYeniHastaGir.Location = new System.Drawing.Point(196, 248);
            this.lnkYeniHastaGir.Name = "lnkYeniHastaGir";
            this.lnkYeniHastaGir.Size = new System.Drawing.Size(136, 25);
            this.lnkYeniHastaGir.TabIndex = 6;
            this.lnkYeniHastaGir.TabStop = true;
            this.lnkYeniHastaGir.Text = "Yeni Hasta Girişi";
            this.lnkYeniHastaGir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYeniHastaGir_LinkClicked);
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.ItemHeight = 25;
            this.lstHastalar.Location = new System.Drawing.Point(75, 345);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.ScrollAlwaysVisible = true;
            this.lstHastalar.Size = new System.Drawing.Size(257, 229);
            this.lstHastalar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "T.C. Kimlik Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Adı:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(5, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-posta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gsm Numarası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Soyadı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Doğum Tarihi:";
            // 
            // lnkHastaGüncelle
            // 
            this.lnkHastaGüncelle.AutoSize = true;
            this.lnkHastaGüncelle.Location = new System.Drawing.Point(190, 26);
            this.lnkHastaGüncelle.Name = "lnkHastaGüncelle";
            this.lnkHastaGüncelle.Size = new System.Drawing.Size(128, 25);
            this.lnkHastaGüncelle.TabIndex = 16;
            this.lnkHastaGüncelle.TabStop = true;
            this.lnkHastaGüncelle.Text = "Hasta Güncelle";
            // 
            // lblTC
            // 
            this.lblTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTC.Location = new System.Drawing.Point(196, 53);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(122, 23);
            this.lblTC.TabIndex = 17;
            // 
            // lblAdres
            // 
            this.lblAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdres.Location = new System.Drawing.Point(140, 301);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(177, 137);
            this.lblAdres.TabIndex = 18;
            // 
            // lblGsm
            // 
            this.lblGsm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGsm.Location = new System.Drawing.Point(196, 270);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(121, 25);
            this.lblGsm.TabIndex = 19;
            this.lblGsm.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelefon.Location = new System.Drawing.Point(196, 239);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(121, 26);
            this.lblTelefon.TabIndex = 20;
            // 
            // lblEposta
            // 
            this.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEposta.Location = new System.Drawing.Point(196, 210);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(121, 25);
            this.lblEposta.TabIndex = 21;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCinsiyet.Location = new System.Drawing.Point(196, 181);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(121, 25);
            this.lblCinsiyet.TabIndex = 22;
            // 
            // lblDoğumTarihi
            // 
            this.lblDoğumTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoğumTarihi.Location = new System.Drawing.Point(197, 150);
            this.lblDoğumTarihi.Name = "lblDoğumTarihi";
            this.lblDoğumTarihi.Size = new System.Drawing.Size(121, 25);
            this.lblDoğumTarihi.TabIndex = 23;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoyad.Location = new System.Drawing.Point(196, 120);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(121, 26);
            this.lblSoyad.TabIndex = 24;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAd.Location = new System.Drawing.Point(197, 86);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(121, 26);
            this.lblAd.TabIndex = 25;
            this.lblAd.Click += new System.EventHandler(this.label20_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(26, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Son Randevu Bilgileri";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(26, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Son Seans Bilgileri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Uzman:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 356);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 25);
            this.label16.TabIndex = 3;
            this.label16.Text = "Uzman:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 25);
            this.label17.TabIndex = 4;
            this.label17.Text = "Seans:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 413);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "Seans:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 474);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 25);
            this.label19.TabIndex = 6;
            this.label19.Text = "Not:";
            // 
            // lblRandevuUzman
            // 
            this.lblRandevuUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandevuUzman.Location = new System.Drawing.Point(154, 103);
            this.lblRandevuUzman.Name = "lblRandevuUzman";
            this.lblRandevuUzman.Size = new System.Drawing.Size(104, 28);
            this.lblRandevuUzman.TabIndex = 7;
            // 
            // lblRandevuSeans
            // 
            this.lblRandevuSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandevuSeans.Location = new System.Drawing.Point(154, 143);
            this.lblRandevuSeans.Name = "lblRandevuSeans";
            this.lblRandevuSeans.Size = new System.Drawing.Size(104, 33);
            this.lblRandevuSeans.TabIndex = 8;
            // 
            // lblSeansUzman
            // 
            this.lblSeansUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeansUzman.Location = new System.Drawing.Point(143, 343);
            this.lblSeansUzman.Name = "lblSeansUzman";
            this.lblSeansUzman.Size = new System.Drawing.Size(104, 38);
            this.lblSeansUzman.TabIndex = 9;
            // 
            // lblSeansSeans
            // 
            this.lblSeansSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeansSeans.Location = new System.Drawing.Point(143, 400);
            this.lblSeansSeans.Name = "lblSeansSeans";
            this.lblSeansSeans.Size = new System.Drawing.Size(104, 38);
            this.lblSeansSeans.TabIndex = 10;
            // 
            // lblSeansNot
            // 
            this.lblSeansNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeansNot.Location = new System.Drawing.Point(143, 461);
            this.lblSeansNot.Name = "lblSeansNot";
            this.lblSeansNot.Size = new System.Drawing.Size(190, 156);
            this.lblSeansNot.TabIndex = 11;
            // 
            // lnkYeniRandevu
            // 
            this.lnkYeniRandevu.AutoSize = true;
            this.lnkYeniRandevu.Location = new System.Drawing.Point(216, 45);
            this.lnkYeniRandevu.Name = "lnkYeniRandevu";
            this.lnkYeniRandevu.Size = new System.Drawing.Size(117, 25);
            this.lnkYeniRandevu.TabIndex = 12;
            this.lnkYeniRandevu.TabStop = true;
            this.lnkYeniRandevu.Text = "Yeni Randevu";
            // 
            // lblRandevuyuİptalEt
            // 
            this.lblRandevuyuİptalEt.AutoSize = true;
            this.lblRandevuyuİptalEt.Location = new System.Drawing.Point(173, 210);
            this.lblRandevuyuİptalEt.Name = "lblRandevuyuİptalEt";
            this.lblRandevuyuİptalEt.Size = new System.Drawing.Size(160, 25);
            this.lblRandevuyuİptalEt.TabIndex = 13;
            this.lblRandevuyuİptalEt.TabStop = true;
            this.lblRandevuyuİptalEt.Text = "Randevuyu İptal Et";
            // 
            // FormHastaveRandevuYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 627);
            this.Controls.Add(this.grpRandevuBilgileri);
            this.Controls.Add(this.grpHastaBilgileri);
            this.Controls.Add(this.grpArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormHastaveRandevuYönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta ve Randevu Yönetimi";
            this.grpArama.ResumeLayout(false);
            this.grpArama.PerformLayout();
            this.grpHastaBilgileri.ResumeLayout(false);
            this.grpHastaBilgileri.PerformLayout();
            this.grpRandevuBilgileri.ResumeLayout(false);
            this.grpRandevuBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpArama;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpHastaBilgileri;
        private GroupBox grpRandevuBilgileri;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnAra;
        private ListBox lstHastalar;
        private LinkLabel lnkYeniHastaGir;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label8;
        private Label label4;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblDoğumTarihi;
        private Label lblCinsiyet;
        private Label lblEposta;
        private Label lblTelefon;
        private Label lblGsm;
        private Label lblAdres;
        private Label lblTC;
        private LinkLabel lnkHastaGüncelle;
        private Label label12;
        private LinkLabel lblRandevuyuİptalEt;
        private LinkLabel lnkYeniRandevu;
        private Label lblSeansNot;
        private Label lblSeansSeans;
        private Label lblSeansUzman;
        private Label lblRandevuSeans;
        private Label lblRandevuUzman;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}