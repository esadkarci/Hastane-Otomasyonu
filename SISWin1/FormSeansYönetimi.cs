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
using SISWin1.SeansXMLWebServisi;

namespace SISWin1
{
    public partial class FormSeansYönetimi : Form
    {
        Calisan uzman = null;
        private void UzmanlariYukle()
        {
            Calisan[] uzmanlar = null;
            try
            {
                CalisanServisi servis = new CalisanServisi();
                uzmanlar = servis.UzmanlariListele();
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }
            cbbUzmanlar.DataSource = uzmanlar;
            cbbUzmanlar.DisplayMember = "GoruntuMetni";
        }
        private void UzmanSeanslariniYukle()
        {
            Seans[] seanslar = null;
            try
            {
                //seanslar = ISK.Seans.UzmanSeanslariniListele(uzman.No);
                SeansServisi servis = new SeansServisi();
                seanslar = servis.UzmanSeanslariniListele(uzman.No);
                servis.Dispose();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }
            lstSeanslar.DataSource= seanslar;
            lstSeanslar.DisplayMember = "GoruntuMetni";
            if (lstSeanslar.Items.Count>0 && lstSeanslar.SelectedIndex>-1)
            {
                linkLabel2.Enabled = true;
            }
            else
            {
                linkLabel2.Enabled=false;
            }
        }
        public FormSeansYönetimi()
        {
            InitializeComponent();
        }

        private void FormSeansYönetimi_Load(object sender, EventArgs e)
        {
            UzmanlariYukle();
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uzman = (Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormYeniSeans frm = new FormYeniSeans();
            frm.uzman = this.uzman;
            frm.ShowDialog();
            UzmanSeanslariniYukle();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Seans seans=(Seans)lstSeanslar.SelectedItem;

            FormSeansIptalEt frm=new FormSeansIptalEt();
            frm.seans = seans;
            frm.ShowDialog();
            UzmanSeanslariniYukle();
        }
    }
}
