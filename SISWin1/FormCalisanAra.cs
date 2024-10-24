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
    public partial class FormCalisanAra : Form
    {
        private void CalisanlariListele()
        {
            Calisan[] calisanlar = null;
            listBox1.DisplayMember = "GoruntuMetni";
            try
            {
                //calisanlar = ISK.Calisan.CalisanlariListele(txtAd.Text, txtSoyad.Text);
                CalisanServisi servis=new CalisanServisi();
                calisanlar = servis.CalisanlariListele(txtAd.Text, txtSoyad.Text);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }
            finally
            {
                listBox1.DataSource = calisanlar;
            }
        }
        public FormCalisanAra()
        {
            InitializeComponent();
        }

        private void lstCAlisanlar_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CalisanlariListele();
        }

        private void lstCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            Calisan calisan = (Calisan)listBox1.SelectedItem;
            if (calisan.CalisanTipi == CalisanTipleri.Sekreter)
            {
                FormSekreterBilgisi frm = new FormSekreterBilgisi();
                frm.calisan = calisan;
                frm.ShowDialog();
            }
            else if (calisan.CalisanTipi == CalisanTipleri.Uzman)
            {
                FormUzmanBilgisi frm = new FormUzmanBilgisi();
                frm.calisan = calisan;
                frm.ShowDialog();
            }
            CalisanlariListele();
            listBox1.SelectedIndex= indeks;
        }

        private void FormCalisanAra_Load(object sender, EventArgs e)
        {

        }
    }
}
