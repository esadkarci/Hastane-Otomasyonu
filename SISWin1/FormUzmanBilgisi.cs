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
    public partial class FormUzmanBilgisi : Form
    {
        public Calisan calisan;
        private void UzmanYukle()
        {
            txtad.Text = calisan.Ad;
            txtEposta.Text = calisan.Eposta;
            txtGsmno.Text = calisan.CepTel;
            txtKimlikno.Text = calisan.TCKimlikNo;
            txtSoyad.Text = calisan.Soyad;
            txtTelno.Text = calisan.EvTel;
            txtUnvan.Text = calisan.Unvan;
        }
        private bool KullaniciGirdisiDogrula()
        {
            if (string.IsNullOrEmpty(txtad.Text))
            {
                MessageBox.Show("Ad bilgisini boş geçemezsin.");
                txtad.SelectAll();
                txtad.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Soyad bilgisini boş geçemezsin.");
                txtSoyad.SelectAll();
                txtSoyad.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEposta.Text))
            {
                MessageBox.Show("Eposta alanını boş geçemezsin.");
                txtEposta.SelectAll();
                txtEposta.Focus();
                return false;
            }
            return true;
        }
        public FormUzmanBilgisi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDogrula();
            if (!dogruMu)
            {
                return;
            }
            if (calisan == null)
            {
                calisan = new Calisan();
            }
            calisan.Ad = txtad.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.TCKimlikNo = txtKimlikno.Text;
            calisan.Unvan = txtUnvan.Text;
            calisan.CalisanTipi = CalisanTipleri.Uzman;
            calisan.CepTel = txtGsmno.Text;
            calisan.Eposta = txtEposta.Text;
            calisan.EvTel = txtTelno.Text;
            int sonuc = 0;
            try
            {
                //sonuc = SISIsKatmani1.Calisan.Kaydet(calisan);
                CalisanServisi servis = new CalisanServisi();
                sonuc = servis.Kaydet(calisan);
                servis.Dispose();

            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");

            }
            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("İŞlem hatalı");
            }
        }

        private void FormUzmanBilgisi_Load(object sender, EventArgs e)
        {
            if (calisan!=null)
            {
                UzmanYukle();
            }
        }
    }
}
