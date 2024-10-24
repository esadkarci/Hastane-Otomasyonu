namespace SISWin
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
            this.lblAyrac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUzman = new System.Windows.Forms.Label();
            this.lblSeans = new System.Windows.Forms.Label();
            this.txtIptalNedeni = new System.Windows.Forms.TextBox();
            this.btnIptalEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SISWin.Properties.Resources.ggggggggggggg;
            this.pictureBox1.Location = new System.Drawing.Point(31, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAyrac
            // 
            this.lblAyrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAyrac.Location = new System.Drawing.Point(226, 205);
            this.lblAyrac.Name = "lblAyrac";
            this.lblAyrac.Size = new System.Drawing.Size(570, 10);
            this.lblAyrac.TabIndex = 1;
            this.lblAyrac.Click += new System.EventHandler(this.lblAyrac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uzman:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seans:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(257, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "İptal Nedeni:";
            // 
            // lblUzman
            // 
            this.lblUzman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUzman.Location = new System.Drawing.Point(425, 78);
            this.lblUzman.Name = "lblUzman";
            this.lblUzman.Size = new System.Drawing.Size(152, 25);
            this.lblUzman.TabIndex = 5;
            // 
            // lblSeans
            // 
            this.lblSeans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeans.Location = new System.Drawing.Point(425, 129);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(152, 25);
            this.lblSeans.TabIndex = 6;
            // 
            // txtIptalNedeni
            // 
            this.txtIptalNedeni.Location = new System.Drawing.Point(412, 227);
            this.txtIptalNedeni.Multiline = true;
            this.txtIptalNedeni.Name = "txtIptalNedeni";
            this.txtIptalNedeni.Size = new System.Drawing.Size(304, 119);
            this.txtIptalNedeni.TabIndex = 7;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Location = new System.Drawing.Point(622, 364);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(148, 59);
            this.btnIptalEt.TabIndex = 8;
            this.btnIptalEt.Text = "İPTAL ET";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            // 
            // FormSeansIptalEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.txtIptalNedeni);
            this.Controls.Add(this.lblSeans);
            this.Controls.Add(this.lblUzman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAyrac);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSeansIptalEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans İptal Et";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAyrac;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblUzman;
        private Label lblSeans;
        private TextBox txtIptalNedeni;
        private Button btnIptalEt;
    }
}