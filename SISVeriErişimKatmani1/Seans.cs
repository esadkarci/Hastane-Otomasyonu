using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SISVeriErişimKatmani1
{
    public class Seans
    {
        public static SISVarliklar1.Seans[] UzmanSeanslariniListele(int uzmanNo)
        {
            string spAdi = "prSeansUzmanSeanslariniListele";
            List<SISVarliklar1.Seans> seanslar = new List<SISVarliklar1.Seans>();
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@uzmanNo", uzmanNo);
            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                SISVarliklar1.Seans seans = SeansBilgileriYukle(sdr);
                seanslar.Add(seans);
            }
            sdr.Close();
            k.Temizle();
            return seanslar.ToArray();
        }
        private static SISVarliklar1.Seans SeansBilgileriYukle(SqlDataReader sdr)
        {
            SISVarliklar1.Seans seans=new SISVarliklar1.Seans();
            seans.BaslangicSaati = Komut.StringGetir(sdr, "BaslangicSaati");
            seans.BitisSaati = Komut.StringGetir(sdr, "BitisSaati");
            seans.HastaNo = Komut.İnt32Getir(sdr, "HastaNo");
            seans.IptalEdenNo = Komut.İnt32Getir(sdr, "IptalEdenNo");
            seans.IptalNotu = Komut.StringGetir(sdr, "IptalNotu");
            seans.No = Komut.İnt32Getir(sdr, "No");
            seans.SeansNotu = Komut.StringGetir(sdr, "SeansNotu");
            seans.Tarih = Komut.TarihGetir(sdr, "Tarih");
            seans.UzmanNo = Komut.İnt32Getir(sdr, "UzmanNo");
            seans.UzmanBilgisi = Komut.StringGetir(sdr, "UzmanBilgisi");
            seans.HastaBilgisi = Komut.StringGetir(sdr, "HastaBilgisi");
            seans.HastaIptalEtti = Komut.BoolGetir(sdr, "HastaIptalEtti");
            return seans;
        }
        public static bool CakismaVarMi(int uzmanNo,DateTime tarih,string baslangicSaati,string bitisSaati)
        {
            string spAdi = "prSeansCakisanSeansSayisi";
            int cakisan = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@uzmanNo", uzmanNo);
            k.ParametreEkle("@tarih", tarih);
            k.ParametreEkle("@baslangicSaati", baslangicSaati);
            k.ParametreEkle("@bitisSaati", bitisSaati);
            cakisan = k.IsletInt32();
            k.Temizle();
            return cakisan > 0;
        }
        public static bool Kaydet(SISVarliklar1.Seans seans)
        {
            string spAdi = "prSeansYeniKaydet";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@uzmanNo", seans.UzmanNo);
            k.ParametreEkle("@tarih", seans.Tarih);
            k.ParametreEkle("@baslangicSaati", seans.BaslangicSaati);
            k.ParametreEkle("@bitisSaati", seans.BitisSaati);
            k.ParametreEkleOut("@seansNo", SqlDbType.Int, 0);
            etkilenen = k.Islet();
            if (etkilenen>0)
            {
                seans.No = k.OutParametreDegeriGetir("@seansNo");
            }
            k.Temizle();
            return etkilenen > 0;
        }
        public static bool IptalEt(SISVarliklar1.Seans seans)
        {
            string spAdi = "prSeansIptalEt";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seans.No);
            k.ParametreEkle("@iptalEdenNo", seans.IptalEdenNo);
            k.ParametreEkle("@iptalNotu", seans.IptalNotu);
            k.ParametreEkle("@hastaIptalEtti", seans.HastaIptalEtti);
            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen>0;
        }
        public static SISVarliklar1.Seans SonRandevuBilgisiGetir(int hastaNo)
        {
            string spAdi = "prSeansHastaSonRandevuBilgisiGetir";
            SISVarliklar1.Seans seans = null;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sdr=k.IsletReader();
            while (sdr.Read())
            {
                seans = SeansBilgileriYukle(sdr);
                
            }
            sdr.Close();
            k.Temizle();
            return seans;
        }
        public static SISVarliklar1.Seans SonSeansBilgisiGetir(int hastaNo)
        {
            string spAdi = "prSeansHastaSonSeansBilgisiGetir";
            SISVarliklar1.Seans seans = null;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);

            SqlDataReader sdr=k.IsletReader() ;
            while (sdr.Read())
            {
                seans = SeansBilgileriYukle(sdr);
            }
            sdr.Close() ;
            k.Temizle();
            return seans;
        }
        public static bool RandevuIptalEt(int seansNo)
        {
            string spadi = "prSeansRandevuIptalEt";
            int etkilenen = 0;
            Komut k=new Komut(spadi);
            k.ParametreEkle("@seansNo", seansNo);
            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen > 0;
        }
        public static bool RandevuKaydet(int seansNo,int hastaNo)
        {
            string spAdi = "prSeansRandevuKaydet";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seansNo);
            k.ParametreEkle("@hastaNo", hastaNo);
            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen > 0;
        }
        public static SISVarliklar1.Seans[] HastaSeanslariniListele(int hastaNo)
        {
            string spAdi = "prSeansHastaSeanslariniListele";
            List<SISVarliklar1.Seans> seanslar = new List<SISVarliklar1.Seans>();
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);
            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                SISVarliklar1.Seans seans = SeansBilgileriYukle(sdr);
                seanslar.Add(seans);
            }
            sdr.Close();
            k.Temizle();
            return seanslar.ToArray();
        }
        public static bool NotGuncelle(int seansNo,string seansNotu)
        {
            string spAdi = "prSeansNotuGuncelle";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@seansNo", seansNo);
            k.ParametreEkle("@seansNotu", seansNotu);
            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen > 0;
        }
    }
}
