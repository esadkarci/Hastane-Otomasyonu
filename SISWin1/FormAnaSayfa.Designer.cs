namespace SISWin1
{
    partial class FormAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniMenü = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniparolasıfırla = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUzmanKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisekreterkaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnicalısanara = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandevuyönet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnieansyönetsekreter = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeansyönetuzman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslKullanıcı = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsiTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslsaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMenü});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mniMenü
            // 
            this.mniMenü.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniParolaDegistir,
            this.mniparolasıfırla,
            this.mniUzmanKaydet,
            this.mnisekreterkaydet,
            this.mnicalısanara,
            this.mniRandevuyönet,
            this.mnieansyönetsekreter,
            this.mniSeansyönetuzman,
            this.toolStripSeparator1,
            this.mniCıkıs});
            this.mniMenü.Name = "mniMenü";
            this.mniMenü.Size = new System.Drawing.Size(73, 29);
            this.mniMenü.Text = "Menü";
            this.mniMenü.Click += new System.EventHandler(this.mEnüToolStripMenuItem_Click);
            // 
            // mniParolaDegistir
            // 
            this.mniParolaDegistir.Name = "mniParolaDegistir";
            this.mniParolaDegistir.Size = new System.Drawing.Size(278, 34);
            this.mniParolaDegistir.Text = "Parola Değiştir";
            this.mniParolaDegistir.Click += new System.EventHandler(this.mniparoladeğiştir_Click);
            // 
            // mniparolasıfırla
            // 
            this.mniparolasıfırla.Name = "mniparolasıfırla";
            this.mniparolasıfırla.Size = new System.Drawing.Size(278, 34);
            this.mniparolasıfırla.Text = "Parola Sıfırla";
            this.mniparolasıfırla.Click += new System.EventHandler(this.mniparolasıfırla_Click);
            // 
            // mniUzmanKaydet
            // 
            this.mniUzmanKaydet.Name = "mniUzmanKaydet";
            this.mniUzmanKaydet.Size = new System.Drawing.Size(278, 34);
            this.mniUzmanKaydet.Text = "Uzman Kaydet";
            this.mniUzmanKaydet.Click += new System.EventHandler(this.mniUzmanKaydet_Click);
            // 
            // mnisekreterkaydet
            // 
            this.mnisekreterkaydet.Name = "mnisekreterkaydet";
            this.mnisekreterkaydet.Size = new System.Drawing.Size(278, 34);
            this.mnisekreterkaydet.Text = "Sekreter Kaydet";
            this.mnisekreterkaydet.Click += new System.EventHandler(this.mnisekreterkaydet_Click);
            // 
            // mnicalısanara
            // 
            this.mnicalısanara.Name = "mnicalısanara";
            this.mnicalısanara.Size = new System.Drawing.Size(278, 34);
            this.mnicalısanara.Text = "Çalışan Ara";
            this.mnicalısanara.Click += new System.EventHandler(this.mnicalısanara_Click);
            // 
            // mniRandevuyönet
            // 
            this.mniRandevuyönet.Name = "mniRandevuyönet";
            this.mniRandevuyönet.Size = new System.Drawing.Size(278, 34);
            this.mniRandevuyönet.Text = "Randevu Yönet";
            this.mniRandevuyönet.Click += new System.EventHandler(this.mniRandevuyönet_Click);
            // 
            // mnieansyönetsekreter
            // 
            this.mnieansyönetsekreter.Name = "mnieansyönetsekreter";
            this.mnieansyönetsekreter.Size = new System.Drawing.Size(278, 34);
            this.mnieansyönetsekreter.Text = "Seans Yönet Sekreter";
            this.mnieansyönetsekreter.Click += new System.EventHandler(this.mnieansyönetsekreter_Click);
            // 
            // mniSeansyönetuzman
            // 
            this.mniSeansyönetuzman.Name = "mniSeansyönetuzman";
            this.mniSeansyönetuzman.Size = new System.Drawing.Size(278, 34);
            this.mniSeansyönetuzman.Text = "Seans Yönet Uzman";
            this.mniSeansyönetuzman.Click += new System.EventHandler(this.mniSeansyönetuzman_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // mniCıkıs
            // 
            this.mniCıkıs.Name = "mniCıkıs";
            this.mniCıkıs.Size = new System.Drawing.Size(278, 34);
            this.mniCıkıs.Text = "Çıkış";
            this.mniCıkıs.Click += new System.EventHandler(this.mniCıkıs_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslKullanıcı,
            this.tsiTarih,
            this.tslsaat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslKullanıcı
            // 
            this.tslKullanıcı.Name = "tslKullanıcı";
            this.tslKullanıcı.Size = new System.Drawing.Size(509, 25);
            this.tslKullanıcı.Spring = true;
            this.tslKullanıcı.Text = "M.Esad KARCI(Sistem Yöneticisi)";
            // 
            // tsiTarih
            // 
            this.tsiTarih.Name = "tsiTarih";
            this.tsiTarih.Size = new System.Drawing.Size(220, 25);
            this.tsiTarih.Text = "24 Temmuz 2023,Pazartesi";
            // 
            // tslsaat
            // 
            this.tslsaat.Name = "tslsaat";
            this.tslsaat.Size = new System.Drawing.Size(56, 25);
            this.tslsaat.Text = "14:14";
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SISWin1.Properties.Resources.desktop_wallpaper_png_stickers_background_light_blue_sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnaSayfa";
            this.Text = "FormAnaSayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniMenü;
        private System.Windows.Forms.ToolStripMenuItem mniParolaDegistir;
        private System.Windows.Forms.ToolStripMenuItem mniparolasıfırla;
        private System.Windows.Forms.ToolStripMenuItem mniUzmanKaydet;
        private System.Windows.Forms.ToolStripMenuItem mnisekreterkaydet;
        private System.Windows.Forms.ToolStripMenuItem mnicalısanara;
        private System.Windows.Forms.ToolStripMenuItem mniRandevuyönet;
        private System.Windows.Forms.ToolStripMenuItem mnieansyönetsekreter;
        private System.Windows.Forms.ToolStripMenuItem mniSeansyönetuzman;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniCıkıs;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslKullanıcı;
        private System.Windows.Forms.ToolStripStatusLabel tsiTarih;
        private System.Windows.Forms.ToolStripStatusLabel tslsaat;
        private System.Windows.Forms.Timer tmrSaat;
    }
}