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
using SISWin1.HastaXMLWebServisi;
using SISWin1.SeansXMLWebServisi;


namespace SISWin1
{
    public partial class FormHastaRandevuYonet : Form
    {
        public Hasta hasta = null;
        private Seans sonRandevu = null;
        private Seans sonSeans = null;
        
        
        private void RandevuBilgisiYukle()
        {
            RandevuBilgisiTemizle();
            try
            {
                //sonRandevu = Seans.SonRandevuBilgisiGetir(hasta.No);
                SeansServisi servis = new SeansServisi();
                sonRandevu = servis.SonRandevuBilgisiGetir(hasta.No);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
            }
            if (sonRandevu!=null)
            {
                lblRandevuSeans.Text = sonRandevu.GoruntuMetni;
                lblRandevuUzman.Text = sonRandevu.UzmanBilgisi;
                lnkRandevuİptalEt.Enabled = true;
            }
            else
            {
                lnkYeniRandevu.Enabled = true;
            }
            try
            {
                //sonSeans = Seans.SonSeansBilgisiGetir(hasta.No);
                SeansServisi servis = new SeansServisi();
                sonSeans = servis.SonSeansBilgisiGetir(hasta.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
                
            }
            if (sonSeans!=null)
            {
                lblSeansUzman.Text = sonSeans.UzmanBilgisi;
                lblSeansSeans.Text = sonSeans.GoruntuMetni;
                lblSeansNot.Text = sonSeans.SeansNotu;
            }
        }
        private void HastalariListele()
        {
            lstHastalar.DisplayMember = "GoruntuMetni";
            
            Hasta[] hastalar = null;
            try
            {
                //hastalar = VIK.Hasta.HastalariListele(txtAd.Text, txtSoyad.Text);
                HastaServisi servis = new HastaServisi();
                hastalar = servis.HastalariListele(txtAd.Text, txtSoyad.Text);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
                
            }
            finally
            {
                lstHastalar.DataSource = hastalar;
            }
        }
        
        private void HastaBilgisiYukle()
        {
            HastaBilgisiTemizle();
            lblAd.Text = hasta.Ad;
            lblAdres.Text = hasta.Adres;
            lblGsm.Text = hasta.CepTel;
            lblCinsiyet.Text = hasta.Cinsiyeti;
            lblDoğum.Text=hasta.DogumTarihi.ToShortDateString();
            lblEposta.Text = hasta.Eposta;
            lblTelefon.Text = hasta.EvTel;
            lblSoyad.Text = hasta.Soyad;
            lblTC.Text = hasta.TCKimlikNo;
        }
        private void HastaBilgisiTemizle()
        {
            lblAd.Text = "";
            lblAdres.Text = "";
            lblGsm.Text = "";
            lblCinsiyet.Text = "";
            lblDoğum.Text = "";
            lblEposta.Text = "";
            lblTelefon.Text = "";
            lblSoyad.Text = "";
            lblTC.Text = "";
        }
        private void RandevuBilgisiTemizle()
        {
            lblRandevuSeans.Text = "";
            lblRandevuUzman.Text = "";
            lblSeansNot.Text = "";
            lblSeansSeans.Text = "";
            lblSeansUzman.Text = "";
            lnkYeniRandevu.Enabled = false;
            lnkRandevuİptalEt.Enabled = false;

        }
        public FormHastaRandevuYonet()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormHastaRandevuYonet_Load(object sender, EventArgs e)
        {
            HastaBilgisiTemizle();
            RandevuBilgisiTemizle();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            HastalariListele();
        }

        private void lnkYeniHastaGir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaBilgisi frm=new FormHastaBilgisi();
            DialogResult cevap = frm.ShowDialog();
            if (cevap==DialogResult.OK)
            {
                txtAd.Text = frm.hasta.Ad;
                HastalariListele();
                if (lstHastalar.Items.Count>0)
                {
                    lstHastalar.SelectedIndex = 0;
                }
            }
        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasta = (Hasta)lstHastalar.Items[lstHastalar.SelectedIndex];
            HastaBilgisiYukle();
            RandevuBilgisiYukle();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int indeks = lstHastalar.SelectedIndex;
            FormHastaBilgisi frm=new FormHastaBilgisi();
            frm.hasta = this.hasta;
            frm.ShowDialog();
            HastalariListele();
            lstHastalar.SelectedIndex = indeks;
        }

        private void lnkYeniRandevu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRandevuKayıt frm = new FormRandevuKayıt();
            frm.hasta=this.hasta;
            frm.ShowDialog();
            RandevuBilgisiYukle();
        }

        private void lnkRandevuİptalEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mesaj = "randevu iptal etmek istediğine emin misin?";
            DialogResult karar = MessageBox.Show(mesaj, "iptal onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (karar==DialogResult.Yes)
            {
                bool sonuc = false;
                try
                {
                    //sonuc = Seans.RandevuIptalEt(sonRandevu.No);
                    SeansServisi servis = new SeansServisi();
                    sonuc = servis.RandevuIptalEt(sonRandevu.No);
                    servis.Dispose();
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex );
                    MessageBox.Show("serviste bir hata oluştu");
                }
                if (sonuc)
                {
                    RandevuBilgisiYukle();
                }
            }
        }
    }
}
