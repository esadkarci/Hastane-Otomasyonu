namespace SISWin
{
    partial class FormParolaDegistir
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
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeni2 = new System.Windows.Forms.TextBox();
            this.txtYeni = new System.Windows.Forms.TextBox();
            this.txtEski = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(257, 233);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(542, 10);
            this.lblAyrac.TabIndex = 0;
            this.lblAyrac.Click += new System.EventHandler(this.lblAyrac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(279, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eski Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(279, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(279, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Parola(Tekrar):";
            // 
            // txtYeni2
            // 
            this.txtYeni2.Location = new System.Drawing.Point(562, 139);
            this.txtYeni2.Name = "txtYeni2";
            this.txtYeni2.PasswordChar = '*';
            this.txtYeni2.Size = new System.Drawing.Size(150, 31);
            this.txtYeni2.TabIndex = 4;
            // 
            // txtYeni
            // 
            this.txtYeni.Location = new System.Drawing.Point(562, 102);
            this.txtYeni.Name = "txtYeni";
            this.txtYeni.PasswordChar = '*';
            this.txtYeni.Size = new System.Drawing.Size(150, 31);
            this.txtYeni.TabIndex = 5;
            // 
            // txtEski
            // 
            this.txtEski.Location = new System.Drawing.Point(562, 65);
            this.txtEski.Name = "txtEski";
            this.txtEski.PasswordChar = '*';
            this.txtEski.Size = new System.Drawing.Size(150, 31);
            this.txtEski.TabIndex = 6;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(562, 273);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(168, 66);
            this.btnDegistir.TabIndex = 7;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.bbbbbbbbbbbbbbb;
            this.pictureBox1.Location = new System.Drawing.Point(34, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormParolaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtEski);
            this.Controls.Add(this.txtYeni);
            this.Controls.Add(this.txtYeni2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAyrac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormParolaDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Değiştir";
            this.Load += new System.EventHandler(this.FormParolaDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAyrac;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtYeni2;
        private TextBox txtYeni;
        private TextBox txtEski;
        private Button btnDegistir;
        private PictureBox pictureBox1;
    }
}