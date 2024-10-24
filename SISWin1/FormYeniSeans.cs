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
using SISWin1.SeansXMLWebServisi;

namespace SISWin1
{
    public partial class FormYeniSeans : Form
    {
        public Calisan uzman;
        private const int enKisaSeansSuresi = 30;
        private bool KullaniciGirisiniDogrula()
        {
            if (dtpBaslangicSaati.Value>dtpBitisSaati.Value)
            {
                MessageBox.Show("bitiş saati başlangıç saatinden önce olmaz");
                dtpBaslangicSaati.Focus();
                return false;
            }
            double seansSuresi = dtpBitisSaati.Value.Subtract(dtpBaslangicSaati.Value).TotalMinutes; ;
            if (seansSuresi<enKisaSeansSuresi)
            {
                MessageBox.Show("seans süresi 30 dakikadan kısa olamaz");
                dtpBitisSaati.Focus();
                return false;
            }
            return true;
        }
        public FormYeniSeans()
        {
            InitializeComponent();
        }

        private void FormYeniSeans_Load(object sender, EventArgs e)
        {
            label5.Text = uzman.GoruntuMetni;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirisiniDogrula();
            if (!dogruMu)
            {
                return;
            }
            Seans seans=new Seans();
            seans.UzmanNo = uzman.No;
            seans.Tarih = dtpTarih.Value;
            seans.BaslangicSaati = dtpBaslangicSaati.Value.ToShortTimeString();
            seans.BitisSaati = dtpBitisSaati.Value.ToShortTimeString();

            int sonuc = 0;
            try
            {
                //sonuc = VIK.Seans.Kaydet(seans);
                SeansServisi servis = new SeansServisi();
                sonuc = servis.Kaydet(seans);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
            }
            if (sonuc>0)
            {
                MessageBox.Show("kayıt işlmei tamamlandı");
                this.Close();
            }
            else if (sonuc == -1)
            {
                MessageBox.Show("Seans saatlerinde çakışma var");
            }
            else
            {
                MessageBox.Show("işlem hatalı");
            }
        }
    }
}
