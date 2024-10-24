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
    public partial class FormRandevuKayıt : Form
    {
        public Hasta hasta;
        private Calisan uzman;
        private Seans seans;
        private void UzmanlariYukle()
        {
            Calisan[] calisanlar = null;
            try
            {
                //   calisanlar = VIK.Calisan.UzmanlariListele();
                CalisanServisi servis = new CalisanServisi();
                calisanlar = servis.UzmanlariListele();
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
                
            }
            cbbUzmanlar.DataSource = calisanlar;
            cbbUzmanlar.DisplayMember = "GoruntuMetni";
        }
        private void UzmanSeanslariniYukle()
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
            cbbSeans.DataSource = seanslar;
            cbbSeans.DisplayMember = "GoruntuMetni";
        }
        private bool KullaniciGirisiniDoğrula()
        {
            if (uzman==null)
            {
                MessageBox.Show("Uzman bilgisini boş bırakamzsınız");
                cbbUzmanlar.Focus();
                return false;
            }
            if (seans==null)
            {
                MessageBox.Show("Seans bilgisini boş geçemezsiniz");
                cbbSeans.Focus();
                return false;
            }
            return true;
        }
        public FormRandevuKayıt()
        {
            InitializeComponent();
        }

        private void FormRandevuKayıt_Load(object sender, EventArgs e)
        {
            lblHasta.Text = hasta.GoruntuMetni;
            UzmanlariYukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirisiniDoğrula();
            bool sonuc = false;
            if (!dogruMu)
            {
                return;
            }
            try
            {
                seans.HastaNo = hasta.No;
                //sonuc = VIK.Seans.RandevuKaydet(seans.No, hasta.No);
                SeansServisi servis = new SeansServisi();
                sonuc = servis.RandevuKaydet(seans.No, hasta.No);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("serviste bir hata oluştu");
            }
            if (sonuc)
            {
                MessageBox.Show("kayıt işlemi tamamlandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("işlem hatalı");
            }
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            uzman = (Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();

        }

        private void cbbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (Seans)cbbSeans.SelectedItem;
        }
    }
}
