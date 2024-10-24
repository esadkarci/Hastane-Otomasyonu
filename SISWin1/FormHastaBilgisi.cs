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
using SISWin1.HastaXMLWebServisi;

namespace SISWin1
{
    public partial class FormHastaBilgisi : Form
    {
        //dialogresult=ok
        public Hasta hasta;
        private void HastaYukle()
        {
            txtAd.Text = hasta.Ad;
            txtSoyad.Text = hasta.Soyad;
            TxtAdres.Text = hasta.Adres;
            txtGsm.Text = hasta.CepTel;
            cbbCinsiyet.SelectedText = hasta.Cinsiyeti;
            dtpDoğum.Value = hasta.DogumTarihi;
            txtEposta.Text = hasta.Eposta;
            txtTel.Text = hasta.EvTel;
            txtTc.Text = hasta.TCKimlikNo;
        }
        private bool KullaniciGirdisiDoğrula()
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Ad bilgisini boş geçemezsiniz");
                txtAd.SelectAll();
                txtAd.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Soyad bilgisini boş geçemezsiniz");
                txtSoyad.SelectAll();
                txtSoyad.Focus();
                return false;
            }
            return true;
        }
        public FormHastaBilgisi()
        {
            InitializeComponent();
        }

        private void FormHastaBilgisi_Load(object sender, EventArgs e)
        {
            dtpDoğum.Value=DateTime.Now;
            cbbCinsiyet.SelectedIndex = 0;
            if (hasta!=null)
            {
                HastaYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirdisiDoğrula();
            if (!dogruMu)
            {
                return;
            }
            if (hasta==null)
            {
                hasta = new Hasta();
            }
            hasta.Ad = txtAd.Text;
            hasta.Adres = TxtAdres.Text;
            hasta.CepTel=txtGsm.Text;
            hasta.Cinsiyeti = cbbCinsiyet.Items[cbbCinsiyet.SelectedIndex].ToString();
            hasta.DogumTarihi = dtpDoğum.Value;
            hasta.Eposta = txtEposta.Text;
            hasta.EvTel=txtTel.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.TCKimlikNo = txtTc.Text;
            int sonuc = 0;
            try
            {
                //sonuc = ISK.Hasta.Kaydet(hasta);
                HastaServisi servis = new HastaServisi();
                sonuc = servis.Kaydet(hasta);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
                
            }
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("işlem hatalı");
            }
        }
    }
}
