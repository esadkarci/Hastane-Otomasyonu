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
    public partial class FormAnaSayfa : Form
    {
        public Calisan calisan;

        private void SaatYaz()
        {
            tslsaat.Text = DateTime.Now.ToLongDateString();
            tsiTarih.Text = DateTime.Now.ToLongDateString();
        }
        private void MenuYukle()
        {
            mniCıkıs.Visible = true;
            mniParolaDegistir.Visible = false;
            mniparolasıfırla.Visible = false;
            mniUzmanKaydet.Visible = false;
            mnisekreterkaydet.Visible = false;
            mnicalısanara.Visible = false;
            mniRandevuyönet.Visible = false;
            mniSeansyönetuzman.Visible = false;
            mnieansyönetsekreter.Visible = false;


            switch (calisan.CalisanTipi)
            {
                case CalisanTipleri.SistemYoneticisi:
                    mnisekreterkaydet.Visible = true;
                    mniParolaDegistir.Visible = true;
                    mniparolasıfırla.Visible = true;
                    tslKullanıcı.Text += "(sistem yöneticisi)";
                    break;
                case CalisanTipleri.Sekreter:
                    mniParolaDegistir.Visible = true;
                    mniUzmanKaydet.Visible = true;
                    mniRandevuyönet.Visible = true;
                    mnieansyönetsekreter.Visible = true;
                    mnicalısanara.Visible = true;

                    tslKullanıcı.Text += "(sekreter)";
                    break;
                case CalisanTipleri.Uzman:
                    mniSeansyönetuzman.Visible = true;
                    mniParolaDegistir.Visible = true;
                    tslKullanıcı.Text += "(uzman)";
                    break;
                    default:
                    break;

            }

        }

        public FormAnaSayfa()
        {

            InitializeComponent();
        }

        private void mEnüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            //   Yardimci.HataKaydet(new Exception("Hata kaydet testi."));
            this.Hide();
            FormGiris frm = new FormGiris();
            frm.ShowDialog(this);

            if (Yardimci.KullaniciNo > 0)
            {
                SaatYaz();
                try
                {
                    // calisan = ISK.Calisan.CalisanGetir(Yardimci.KullaniciNo);
                    CalisanServisi servis = new CalisanServisi();
                    calisan = servis.CalisanGetir(Yardimci.KullaniciNo);
                    servis.Dispose();
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu");
                }
                tslKullanıcı.Text = calisan.GoruntuMetni;
                tslKullanıcı.Text = calisan.GoruntuMetni;
                MenuYukle();
            }
            else
            {

                this.Close();
            }
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void mniparoladeğiştir_Click(object sender, EventArgs e)
        {

            FormParolaDegistir frm = new FormParolaDegistir();
            frm.calisan = this.calisan;
            frm.ShowDialog();

        }

        private void mniparolasıfırla_Click(object sender, EventArgs e)
        {
            FormParolaSıfırlamaEkranı frm = new FormParolaSıfırlamaEkranı();
            frm.ShowDialog();
        }

        private void mniUzmanKaydet_Click(object sender, EventArgs e)
        {
            FormUzmanBilgisi frm = new FormUzmanBilgisi();
            frm.ShowDialog();
        }

        private void mnisekreterkaydet_Click(object sender, EventArgs e)
        {
            FormSekreterBilgisi frm = new FormSekreterBilgisi();
            frm.ShowDialog();
        }

        private void mnicalısanara_Click(object sender, EventArgs e)
        {
            FormCalisanAra frm = new FormCalisanAra();
            frm.ShowDialog();
        }

        private void mniRandevuyönet_Click(object sender, EventArgs e)
        {
            FormRandevuKayıt frm = new FormRandevuKayıt();
            frm.ShowDialog();
        }

        private void mnieansyönetsekreter_Click(object sender, EventArgs e)
        {
            FormSeansYönetimi frm = new FormSeansYönetimi();
            frm.ShowDialog();
        }

        private void mniSeansyönetuzman_Click(object sender, EventArgs e)
        {
            FormUzmanSeansYonetimi frm = new FormUzmanSeansYonetimi();
            frm.ShowDialog();
        }

        private void mniCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
