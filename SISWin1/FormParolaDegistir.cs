
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using VAR = SISVarliklar1;
//using ISK = SISIsKatmani1;
using SISWin1.CalisanXMLWebServisi;

namespace SISWin1
{
    public partial class FormParolaDegistir : Form
    {
       public Calisan calisan;
        private bool KullaniciGirdisiDoğrula()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Eski parola bilgisini boş geçemzsiniz");
                textBox1.SelectAll();
                textBox1.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Yeni parola bilgisini boş geçemzsiniz");
                textBox2.SelectAll();
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Yeni parola tekrarı bilgisini boş geçemzsiniz");
                textBox3.SelectAll();
                textBox3.Focus();
                return false;
            }
            if (textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("Yeni parola ve tekrarı aynı olmalı");
                textBox3.SelectAll();
                textBox3.Focus();
                return false;
            }
            return true;
        }

        public FormParolaDegistir()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            bool doguMu = KullaniciGirdisiDoğrula();
            if (!doguMu)
            {
                return;
            }
            bool sonuc = false;
            try
            {
                // sonuc = ISK.Calisan.ParolaDegistir(calisan.No, textBox2.Text);
                CalisanServisi servis = new CalisanServisi();
                sonuc = servis.parolaDegistir(calisan.No, textBox2.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }
            if (sonuc)
            {
                MessageBox.Show("parola değiştirildi");
                this.Close();
            }
            else
            {
                MessageBox.Show("işlem geerçekleştirilirken bir hata oluştu");
            }
        }

        private void FormParolaDegistir_Load(object sender, EventArgs e)
        {

        }
    }
}
