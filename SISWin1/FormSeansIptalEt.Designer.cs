namespace SISWin1
{
    partial class FormSeansIptalEt
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
            this.lblUzman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeans = new System.Windows.Forms.Label();
            this.txtIptalNedeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIPtalEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin1.Properties.Resources.ggggggggggggg;
            this.pictureBox1.Location = new System.Drawing.Point(57, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uzman";
            // 
            // lblUzman
            // 
            this.lblUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUzman.Location = new System.Drawing.Point(498, 99);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(100, 23);
            this.lblUzman.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seans";
            // 
            // lblSeans
            // 
            this.lblSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeans.Location = new System.Drawing.Point(499, 158);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(100, 23);
            this.lblSeans.TabIndex = 4;
            // 
            // txtIptalNedeni
            // 
            this.txtIptalNedeni.Location = new System.Drawing.Point(501, 224);
            this.txtIptalNedeni.Multiline = true;
            this.txtIptalNedeni.Name = "txtIptalNedeni";
            this.txtIptalNedeni.Size = new System.Drawing.Size(255, 154);
            this.txtIptalNedeni.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "İptal Nedeni";
            // 
            // btnIPtalEt
            // 
            this.btnIPtalEt.Location = new System.Drawing.Point(622, 385);
            this.btnIPtalEt.Name = "btnIPtalEt";
            this.btnIPtalEt.Size = new System.Drawing.Size(134, 40);
            this.btnIPtalEt.TabIndex = 7;
            this.btnIPtalEt.Text = "İptal Et";
            this.btnIPtalEt.UseVisualStyleBackColor = true;
            this.btnIPtalEt.Click += new System.EventHandler(this.btnIPtalEt_Click);
            // 
            // FormSeansIptalEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIPtalEt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIptalNedeni);
            this.Controls.Add(this.lblSeans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUzman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeansIptalEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans İptal Et";
            this.Load += new System.EventHandler(this.FormSeansIptalEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUzman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeans;
        private System.Windows.Forms.TextBox txtIptalNedeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIPtalEt;
    }
}