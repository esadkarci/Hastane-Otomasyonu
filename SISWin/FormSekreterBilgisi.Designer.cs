namespace SISWin
{
    partial class FormSekreterBilgisi
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
            this.lblAyır = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtGSMNumarası = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.png_transparent_computer_icons_user_profile_avatar_urban_scholars_program_avatar_cdr_heroes_monochrome;
            this.pictureBox1.Location = new System.Drawing.Point(28, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAyır
            // 
            this.lblAyır.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyır.Location = new System.Drawing.Point(306, 296);
            this.lblAyır.Name = "lblAyır";
            this.lblAyır.Size = new System.Drawing.Size(493, 10);
            this.lblAyır.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(376, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(376, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(376, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon Numarası:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(376, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "GSM Numarası:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(592, 48);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(150, 31);
            this.txtTC.TabIndex = 8;
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(592, 85);
            this.txtAdı.MaxLength = 50;
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(150, 31);
            this.txtAdı.TabIndex = 9;
            this.txtAdı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtGSMNumarası
            // 
            this.txtGSMNumarası.Location = new System.Drawing.Point(592, 233);
            this.txtGSMNumarası.MaxLength = 50;
            this.txtGSMNumarası.Name = "txtGSMNumarası";
            this.txtGSMNumarası.Size = new System.Drawing.Size(150, 31);
            this.txtGSMNumarası.TabIndex = 10;
            this.txtGSMNumarası.TextChanged += new System.EventHandler(this.btnGSMNumarası_TextChanged);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(592, 196);
            this.txtTelNo.MaxLength = 50;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(150, 31);
            this.txtTelNo.TabIndex = 11;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(592, 159);
            this.txtEposta.MaxLength = 100;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(150, 31);
            this.txtEposta.TabIndex = 12;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(592, 122);
            this.txtSoyadı.MaxLength = 50;
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(150, 31);
            this.txtSoyadı.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(592, 335);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(154, 62);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormSekreterBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtGSMNumarası);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyır);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSekreterBilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter";
            this.Load += new System.EventHandler(this.FormSekreterBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAyır;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTC;
        private TextBox txtAdı;
        private TextBox txtGSMNumarası;
        private TextBox txtTelNo;
        private TextBox txtEposta;
        private TextBox txtSoyadı;
        private Button btnKaydet;
    }
}