namespace SISWin1
{
    partial class FormRandevuKayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbUzmanlar = new System.Windows.Forms.ComboBox();
            this.cbbSeans = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin1.Properties.Resources.hjhjhjh;
            this.pictureBox1.Location = new System.Drawing.Point(38, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uzman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seans";
            // 
            // cbbUzmanlar
            // 
            this.cbbUzmanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUzmanlar.FormattingEnabled = true;
            this.cbbUzmanlar.Location = new System.Drawing.Point(437, 151);
            this.cbbUzmanlar.Name = "cbbUzmanlar";
            this.cbbUzmanlar.Size = new System.Drawing.Size(121, 28);
            this.cbbUzmanlar.TabIndex = 4;
            this.cbbUzmanlar.SelectedIndexChanged += new System.EventHandler(this.cbbUzmanlar_SelectedIndexChanged);
            // 
            // cbbSeans
            // 
            this.cbbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeans.FormattingEnabled = true;
            this.cbbSeans.Location = new System.Drawing.Point(437, 195);
            this.cbbSeans.Name = "cbbSeans";
            this.cbbSeans.Size = new System.Drawing.Size(121, 28);
            this.cbbSeans.TabIndex = 5;
            this.cbbSeans.SelectedIndexChanged += new System.EventHandler(this.cbbSeans_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(499, 306);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(192, 44);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasta.Location = new System.Drawing.Point(437, 119);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(121, 23);
            this.lblHasta.TabIndex = 7;
            // 
            // FormRandevuKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbbSeans);
            this.Controls.Add(this.cbbUzmanlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRandevuKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Kayıt";
            this.Load += new System.EventHandler(this.FormRandevuKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbUzmanlar;
        private System.Windows.Forms.ComboBox cbbSeans;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblHasta;
    }
}