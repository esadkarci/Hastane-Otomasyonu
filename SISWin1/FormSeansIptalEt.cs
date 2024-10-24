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
using SISWin1.SeansXMLWebServisi;

namespace SISWin1
{
    public partial class FormSeansIptalEt : Form
    {
        public Seans seans;
        private bool KullaniciGirisiniDoğrula()
        {
            if (string.IsNullOrEmpty(txtIptalNedeni.Text))
            {
                MessageBox.Show("iptal nedenini boş geçemezsiniz");
                txtIptalNedeni.SelectAll();
                txtIptalNedeni.Focus();
                return false;
            }
            return true;
        }
        public FormSeansIptalEt()
        {
            InitializeComponent();
        }

        private void FormSeansIptalEt_Load(object sender, EventArgs e)
        {
            lblUzman.Text = seans.UzmanBilgisi;
            lblSeans.Text = seans.GoruntuMetni;
            seans.IptalEdenNo = Program.KullaniciNo;
        }

        private void btnIPtalEt_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullaniciGirisiniDoğrula();
            if (!dogruMu)
            {
                return;
            }
            bool sonuc = false;
            try
            {
                // sonuc = VIK.Seans.IptalEt(seans);
                SeansServisi servis = new SeansServisi();
                sonuc = servis.IptalEt(seans);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }
            if (sonuc)
            {
                MessageBox.Show("Seans iptal edildi");
            }
            else
            {
                MessageBox.Show("Oluşan hata nedeniyle seans iptal edilemedi");
            }
            this.Close();

        }
    }
}
