namespace SISWin
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
            this.mniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParolaSifirla = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUzmanKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSekreterKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCalisanAra = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRandevuYonet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeansYonetSekreter = new System.Windows.Forms.ToolStripMenuItem();
            this.SeansYonetUzman = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAyrac = new System.Windows.Forms.ToolStripSeparator();
            this.mniCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mniMenu
            // 
            this.mniMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniParolaDegistir,
            this.mniParolaSifirla,
            this.mniUzmanKaydet,
            this.mniSekreterKaydet,
            this.mniCalisanAra,
            this.mniRandevuYonet,
            this.mniSeansYonetSekreter,
            this.SeansYonetUzman,
            this.mniAyrac,
            this.mniCıkıs});
            this.mniMenu.Name = "mniMenu";
            this.mniMenu.Size = new System.Drawing.Size(73, 29);
            this.mniMenu.Text = "&Menü";
            this.mniMenu.Click += new System.EventHandler(this.mniMenü_Click);
            // 
            // mniParolaDegistir
            // 
            this.mniParolaDegistir.Name = "mniParolaDegistir";
            this.mniParolaDegistir.Size = new System.Drawing.Size(278, 34);
            this.mniParolaDegistir.Text = "Paralo&Değiştir";
            this.mniParolaDegistir.Click += new System.EventHandler(this.paraloDeğiştirToolStripMenuItem_Click);
            // 
            // mniParolaSifirla
            // 
            this.mniParolaSifirla.Name = "mniParolaSifirla";
            this.mniParolaSifirla.Size = new System.Drawing.Size(278, 34);
            this.mniParolaSifirla.Text = "Paralo Sıfırla";
            this.mniParolaSifirla.Click += new System.EventHandler(this.paraloSıfırlaToolStripMenuItem_Click);
            // 
            // mniUzmanKaydet
            // 
            this.mniUzmanKaydet.Name = "mniUzmanKaydet";
            this.mniUzmanKaydet.Size = new System.Drawing.Size(278, 34);
            this.mniUzmanKaydet.Text = "Uzman Kaydet";
            this.mniUzmanKaydet.Click += new System.EventHandler(this.uzmanEkleToolStripMenuItem_Click);
            // 
            // mniSekreterKaydet
            // 
            this.mniSekreterKaydet.Name = "mniSekreterKaydet";
            this.mniSekreterKaydet.Size = new System.Drawing.Size(278, 34);
            this.mniSekreterKaydet.Text = "Sekreter Kaydet";
            this.mniSekreterKaydet.Click += new System.EventHandler(this.sekreterKaydetToolStripMenuItem_Click);
            // 
            // mniCalisanAra
            // 
            this.mniCalisanAra.Name = "mniCalisanAra";
            this.mniCalisanAra.Size = new System.Drawing.Size(278, 34);
            this.mniCalisanAra.Text = "Çalışan Ara";
            this.mniCalisanAra.Click += new System.EventHandler(this.çalışanAraToolStripMenuItem_Click);
            // 
            // mniRandevuYonet
            // 
            this.mniRandevuYonet.Name = "mniRandevuYonet";
            this.mniRandevuYonet.Size = new System.Drawing.Size(278, 34);
            this.mniRandevuYonet.Text = "Randevu Yönet";
            this.mniRandevuYonet.Click += new System.EventHandler(this.randevuYönetToolStripMenuItem_Click);
            // 
            // mniSeansYonetSekreter
            // 
            this.mniSeansYonetSekreter.Name = "mniSeansYonetSekreter";
            this.mniSeansYonetSekreter.Size = new System.Drawing.Size(278, 34);
            this.mniSeansYonetSekreter.Text = "Seans Yönet Sekreter";
            this.mniSeansYonetSekreter.Click += new System.EventHandler(this.seansYönetToolStripMenuItem_Click);
            // 
            // SeansYonetUzman
            // 
            this.SeansYonetUzman.Name = "SeansYonetUzman";
            this.SeansYonetUzman.Size = new System.Drawing.Size(278, 34);
            this.SeansYonetUzman.Text = "Seans Yönet Uzman";
            this.SeansYonetUzman.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // mniAyrac
            // 
            this.mniAyrac.Name = "mniAyrac";
            this.mniAyrac.Size = new System.Drawing.Size(275, 6);
            // 
            // mniCıkıs
            // 
            this.mniCıkıs.Name = "mniCıkıs";
            this.mniCıkıs.Size = new System.Drawing.Size(278, 34);
            this.mniCıkıs.Text = "Çıkış";
            this.mniCıkıs.Click += new System.EventHandler(this.çıkışToolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslKullanici,
            this.tslTarih,
            this.tslSaat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tslKullanici
            // 
            this.tslKullanici.Name = "tslKullanici";
            this.tslKullanici.Size = new System.Drawing.Size(583, 25);
            this.tslKullanici.Spring = true;
            this.tslKullanici.Text = "M.Esad KARCI (Sistem Yöneticisi)";
            this.tslKullanici.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tslTarih
            // 
            this.tslTarih.Name = "tslTarih";
            this.tslTarih.Size = new System.Drawing.Size(100, 25);
            this.tslTarih.Text = "11.07.2023";
            this.tslTarih.Click += new System.EventHandler(this.tslTarih_Click);
            // 
            // tslSaat
            // 
            this.tslSaat.Name = "tslSaat";
            this.tslSaat.Size = new System.Drawing.Size(56, 25);
            this.tslSaat.Text = "18:18";
            this.tslSaat.Click += new System.EventHandler(this.tslSaat_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.AutoClose = false;
            this.çıkışToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            this.çıkışToolStripMenuItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.çıkışToolStripMenuItem_ItemClicked);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SISWin.Properties.Resources.DosyaIncelemesi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FormAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIS Ana Sayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslKullanici;
        private ToolStripStatusLabel tslTarih;
        private ToolStripStatusLabel tslSaat;
        private ToolStripMenuItem mniMenu;
        private ToolStripMenuItem mniParolaDegistir;
        private ToolStripMenuItem mniParolaSifirla;
        private ToolStripMenuItem mniUzmanKaydet;
        private ToolStripMenuItem mniSekreterKaydet;
        private ToolStripMenuItem mniCalisanAra;
        private ToolStripMenuItem mniRandevuYonet;
        private ToolStripMenuItem mniSeansYonetSekreter;
        private ToolStripMenuItem SeansYonetUzman;
        private ToolStripSeparator mniAyrac;
        private ToolStripMenuItem mniCıkıs;
        private ToolStripDropDownMenu çıkışToolStripMenuItem;
        private System.Windows.Forms.Timer tmrSaat;
    }
}