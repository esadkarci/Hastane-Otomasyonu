using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SISWin
{
    public partial class FormAnaSayfa : Form
    {
        
        public FormAnaSayfa()
        {

            InitializeComponent();

        }
        // public VAR.Calisan calisan;
        private void SaatYaz()
        {
            tslSaat.Text = DateTime.Now.ToLongTimeString();
            tslTarih.Text = DateTime.Now.ToLongDateString();
        }
        private void MenuYukle()
        {
            mniCıkıs.Visible = true;
            mniParolaDegistir.Visible = true;
        }
        //switch (calisan.CalisanTİpi)
        //{
        //    case var.Calisan.CalisanTipleri.SistemYoneticisi;
        //    mniSekrete
          

        //}
        private void uzmanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUzmanBilgisi frm=new FormUzmanBilgisi();
            frm.ShowDialog();
        }

        private void tslTarih_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUzmanSeansYönetim frm = new FormUzmanSeansYönetim();
            frm.ShowDialog();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void çıkışToolStripMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mniMenü_Click(object sender, EventArgs e)
        {

        }

        private void tslSaat_Click(object sender, EventArgs e)
        {

        }

        private void paraloDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParolaDegistir frm = new FormParolaDegistir();
            frm.calisan = this.calisan;
            frm.ShowDialog();
        }

        private void paraloSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParolaSıfırlama frm=new FormParolaSıfırlama();
            frm.ShowDialog();
        }

        private void sekreterKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSekreterBilgisi frm=new FormSekreterBilgisi();
            frm.ShowDialog();
        }

        private void çalışanAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalısanAra frm= new FormCalısanAra();
            frm.ShowDialog();
        }

        private void randevuYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHastaveRandevuYönetimi frm= new FormHastaveRandevuYönetimi();
            frm.ShowDialog();
        }

        private void seansYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeansYönetimi frm = new FormSeansYönetimi();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
