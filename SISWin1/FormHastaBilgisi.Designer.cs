namespace SISWin1
{
    partial class FormHastaBilgisi
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
            this.cbbCinsiyet = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpDoğum = new System.Windows.Forms.DateTimePicker();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCinsiyet
            // 
            this.cbbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCinsiyet.FormattingEnabled = true;
            this.cbbCinsiyet.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cbbCinsiyet.Location = new System.Drawing.Point(488, 156);
            this.cbbCinsiyet.Name = "cbbCinsiyet";
            this.cbbCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cbbCinsiyet.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin1.Properties.Resources.png_transparent_computer_icons_user_profile_avatar_profile_heroes_profile_user1;
            this.pictureBox1.Location = new System.Drawing.Point(35, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "E posta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gsm No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Adres";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(488, 15);
            this.txtTc.MaxLength = 50;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 26);
            this.txtTc.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(488, 49);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(488, 82);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 13;
            // 
            // dtpDoğum
            // 
            this.dtpDoğum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoğum.Location = new System.Drawing.Point(488, 121);
            this.dtpDoğum.Name = "dtpDoğum";
            this.dtpDoğum.Size = new System.Drawing.Size(121, 26);
            this.dtpDoğum.TabIndex = 14;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(488, 198);
            this.txtEposta.MaxLength = 100;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 26);
            this.txtEposta.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(488, 244);
            this.txtTel.MaxLength = 50;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 26);
            this.txtTel.TabIndex = 16;
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(488, 284);
            this.txtGsm.MaxLength = 50;
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(100, 26);
            this.txtGsm.TabIndex = 17;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(488, 317);
            this.TxtAdres.MaxLength = 250;
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(273, 78);
            this.TxtAdres.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(612, 401);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 37);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormHastaBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.dtpDoğum);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbCinsiyet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHastaBilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgisi";
            this.Load += new System.EventHandler(this.FormHastaBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCinsiyet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dtpDoğum;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Button btnKaydet;
    }
}