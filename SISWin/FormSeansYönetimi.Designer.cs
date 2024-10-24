namespace SISWin
{
    partial class FormSeansYönetimi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbUzmanlar = new System.Windows.Forms.ComboBox();
            this.lstSeanslar = new System.Windows.Forms.ListBox();
            this.lnkSeansEkle = new System.Windows.Forms.LinkLabel();
            this.lnkSeansIptalEt = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.dddddddddddddddd;
            this.pictureBox1.Location = new System.Drawing.Point(36, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(263, 137);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(525, 10);
            this.lblAyrac.TabIndex = 1;
            this.lblAyrac.Click += new System.EventHandler(this.lblAyrac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uzman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(293, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seanslar:";
            // 
            // cbbUzmanlar
            // 
            this.cbbUzmanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUzmanlar.FormattingEnabled = true;
            this.cbbUzmanlar.Location = new System.Drawing.Point(439, 60);
            this.cbbUzmanlar.Name = "cbbUzmanlar";
            this.cbbUzmanlar.Size = new System.Drawing.Size(182, 33);
            this.cbbUzmanlar.TabIndex = 4;
            // 
            // lstSeanslar
            // 
            this.lstSeanslar.FormattingEnabled = true;
            this.lstSeanslar.ItemHeight = 25;
            this.lstSeanslar.Location = new System.Drawing.Point(388, 183);
            this.lstSeanslar.Name = "lstSeanslar";
            this.lstSeanslar.ScrollAlwaysVisible = true;
            this.lstSeanslar.Size = new System.Drawing.Size(302, 204);
            this.lstSeanslar.TabIndex = 5;
            // 
            // lnkSeansEkle
            // 
            this.lnkSeansEkle.AutoSize = true;
            this.lnkSeansEkle.Location = new System.Drawing.Point(560, 155);
            this.lnkSeansEkle.Name = "lnkSeansEkle";
            this.lnkSeansEkle.Size = new System.Drawing.Size(130, 25);
            this.lnkSeansEkle.TabIndex = 6;
            this.lnkSeansEkle.TabStop = true;
            this.lnkSeansEkle.Text = "Yeni Seans Ekle";
            this.lnkSeansEkle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkSeansIptalEt
            // 
            this.lnkSeansIptalEt.AutoSize = true;
            this.lnkSeansIptalEt.Location = new System.Drawing.Point(524, 390);
            this.lnkSeansIptalEt.Name = "lnkSeansIptalEt";
            this.lnkSeansIptalEt.Size = new System.Drawing.Size(166, 25);
            this.lnkSeansIptalEt.TabIndex = 7;
            this.lnkSeansIptalEt.TabStop = true;
            this.lnkSeansIptalEt.Text = "Seçili Seansı İptal Et";
            // 
            // FormSeansYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkSeansIptalEt);
            this.Controls.Add(this.lnkSeansEkle);
            this.Controls.Add(this.lstSeanslar);
            this.Controls.Add(this.cbbUzmanlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeansYönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAyrac;
        private Label label1;
        private Label label2;
        private ComboBox cbbUzmanlar;
        private ListBox lstSeanslar;
        private LinkLabel lnkSeansEkle;
        private LinkLabel lnkSeansIptalEt;
    }
}