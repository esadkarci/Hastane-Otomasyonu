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
    public partial class FormGiris : Form
    {
        
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        { 

        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı bilgisini boş geçemezsiniz");
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Parola bilgisini boş geçemezsiniz");
                textBox2.SelectAll();
                textBox2.Focus();
                return;
            }
            int calisanNo = 0;
            try
            {
                //calisanNo=ISK.Calisan.KullaniciGirisiniDogrula(textBox1.Text,textBox2.Text);
               
                CalisanServisi servis = new CalisanServisi();
                calisanNo = servis.KullaniciGirisiniDogrula(textBox1.Text, textBox2.Text);
                
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
                
            }
            if (calisanNo>0)
            {
                Yardimci.KullaniciNo = calisanNo;
                this.Close();   
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı/parola Bilgisi!");
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }
    }
}
