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
//using VIK = SISIsKatmani1;
using SISWin1.CalisanXMLWebServisi;
using SISWin1.HastaXMLWebServisi;
using SISWin1.SeansXMLWebServisi;
namespace SISWin1
{
    public partial class FormUzmanSeansYonetimi : Form
    {
        public Calisan uzman = null;
        private Hasta hasta = null;
        private Seans aktifSeans = null;
        private Seans gecmisSeans = null;
        private void UzmanSeanslarınıYukle()
        {
            Seans[] seanslar = null;
            try
            {
                //seanslar = VIK.Seans.UzmanSeanslariniListele(uzman.No);
                SeansServisi servis = new SeansServisi();
                seanslar = servis.UzmanSeanslariniListele(uzman.No);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
            }
            cbbSeanslar.DataSource = seanslar;
            cbbSeanslar.DisplayMember = "GoruntuMetni";
        }
        private void BilgileriYukle()
        {
            if (hasta!=null)
            {
                lblAd.Text = hasta.Ad;
                lblAdres.Text = hasta.Adres;
                lblGsm.Text = hasta.CepTel;
                lblCinsiyet.Text = hasta.Cinsiyeti;
                lblDoğum.Text = hasta.DogumTarihi.ToShortDateString();
                lblEposta.Text = hasta.Eposta;
                lblTel.Text = hasta.EvTel;
                lblSoyad.Text = hasta.Soyad;
                lblTC.Text = hasta.TCKimlikNo;
                txtAktifSeansNotu.Text = aktifSeans.SeansNotu;
                Seans[] hastaSeanslari = null;
                try
                {
                    //hastaSeanslari = VIK.Seans.HastaSeanslariniListele(hasta.No);
                    SeansServisi servis = new SeansServisi();
                    hastaSeanslari = servis.HastaSeanslariniListele(hasta.No);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("serviste bir hata oluştu");
                    
                }
                lstSeanslar.DataSource = hastaSeanslari;
                lstSeanslar.DisplayMember = "GoruntuMetni";
            }
        }
        private bool SeansNotuKaydet(int seansNo, string seansNotu)
        {
            bool sonuc = false;
            try
            {
                //sonuc = VIK.Seans.NotGuncelle(seansNo, seansNotu);
                SeansServisi servis = new SeansServisi();
                sonuc = servis.NotGuncelle(seansNo, seansNotu);
                servis.Dispose();

            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
                
            }
            return sonuc;
        }
        private void EkranıTemizle()
        {
            hasta = null;
            lblTC.Text = "";
            lblAd.Text = "";
            lblAdres.Text = "";
            lblGsm.Text = "";
            lblCinsiyet.Text = "";
            lblDoğum.Text = "";
            lblEposta.Text = "";
            lblTel.Text = "";
            lblSoyad.Text = "";

        }
        public FormUzmanSeansYonetimi()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormUzmanSeansYonetimi_Load(object sender, EventArgs e)
        {
            EkranıTemizle();
            try
            {
                // uzman = VIK.Calisan.CalisanGetir(Program.KullaniciNo);
                CalisanServisi servis = new CalisanServisi();
                uzman = servis.CalisanGetir(Yardimci.KullaniciNo);
                servis.Dispose();

            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
            }
            UzmanSeanslarınıYukle();
        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            EkranıTemizle();
            aktifSeans = (Seans)cbbSeanslar.SelectedItem;
            if (aktifSeans.HastaNo>0)
            {
                try
                {
                    //hasta = VIK.Hasta.HastaGetir(aktifSeans.HastaNo);
                    HastaServisi servis = new HastaServisi();
                    hasta = servis.HastaGetir(aktifSeans.HastaNo);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("serviste bir hata oluştu");
                }
            }
            BilgileriYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGeçmişSeansNOtu.Text))
            {
                MessageBox.Show("Eski Seans için seanas notu giriniz.");
                txtGeçmişSeansNOtu.Focus();
                return;
            }
            bool sonuc = SeansNotuKaydet(gecmisSeans.No, txtGeçmişSeansNOtu.Text);
            if (sonuc)
            {
                MessageBox.Show("Eski seans notu güncellendi.");
                gecmisSeans.SeansNotu = txtGeçmişSeansNOtu.Text;
            }
            else
            {
                MessageBox.Show("İşlem gerçekleşmedi");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAktifSeansNotu.Text))
            {
                MessageBox.Show("Aktif seans notu giriniz");
                txtAktifSeansNotu.Focus();
                return;
            }
            bool sonuc = SeansNotuKaydet(aktifSeans.No, txtAktifSeansNotu.Text);
            if (sonuc)
            {
                MessageBox.Show("Yeni seans notu kayıt edildi.");
                aktifSeans.SeansNotu = txtAktifSeansNotu.Text;
                EkranıTemizle();
                UzmanSeanslarınıYukle();
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilmedi");
            }
        }

        private void lstSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gecmisSeans = (Seans)lstSeanslar.SelectedItem;
            if (gecmisSeans != null)
            {
                txtGeçmişSeansNOtu.Text = gecmisSeans.SeansNotu;
            }
        }
    }
}
