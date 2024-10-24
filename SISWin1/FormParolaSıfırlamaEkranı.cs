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
    public partial class FormParolaSıfırlamaEkranı : Form
    {

        public FormParolaSıfırlamaEkranı()
        {
            InitializeComponent();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {

            bool doguMu = KullaniciGirdisiDogrula();
            if (!doguMu)
            {
                return;
            }
            bool sonuc = false;
            try
            {
                //sonuc = ISK.Calisan.ParolaSifirla(txtEposta.Text,txtparola.Text);
                CalisanServisi servis = new CalisanServisi();
                sonuc = servis.parolaSifirla(txtEposta.Text, txtparola.Text);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }
            if (sonuc)
            {
                MessageBox.Show("parola sıfırlandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("işlem geerçekleştirilirken bir hata oluştu");
            }
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtEposta.Text))
            {
                MessageBox.Show("Eposta bilgisini boş geçemezsiniz");
                txtEposta.SelectAll();
                txtEposta.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtparola.Text))
            {
                MessageBox.Show("Parola bilgisini boş geçemezsiniz");
                txtparola.SelectAll();
                txtparola.Focus();
                return false;
            }
            return true;
        }

        private void FormParolaSıfırlamaEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
