using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SISVeriErişimKatmani1
{
    public class Calisan
    {
        public static int KullaniciGirisiniDogrula(string ePosta, string parola)
        {
            string spAdi = "prCalisanGirisiniDogrula";
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@ePosta", ePosta);
            k.ParametreEkle("@parola", parola);
            int sonuc = k.IsletInt32();
            k.Temizle();
            return sonuc;
        }
        public static SISVarliklar1.Calisan CalisanGetir(int calisanNo)
        {
            string spAdi = "prCalisanGetir";
            SISVarliklar1.Calisan calisan = null;
            Komut k=new Komut(spAdi);
            k.ParametreEkle("@calisanNo", calisanNo);
            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                calisan = CalisanBilgileriYukle(sdr);
            }
            sdr.Close();
            k.Temizle();
            return calisan;
        }
        private static SISVarliklar1.Calisan CalisanBilgileriYukle(SqlDataReader sdr)
        {
            SISVarliklar1.Calisan calisan = new SISVarliklar1.Calisan();
            try
            {
                calisan.No = Komut.İnt32Getir(sdr, "CalisanNo");
                calisan.Ad = Komut.StringGetir(sdr, "Ad");
                calisan.CepTel = Komut.StringGetir(sdr, "CepTel");
                calisan.Eposta = Komut.StringGetir(sdr, "Eposta");
                calisan.EvTel = Komut.StringGetir(sdr, "EvTel");
                calisan.Soyad = Komut.StringGetir(sdr, "Soyad");
                calisan.TCKimlikNo = Komut.StringGetir(sdr, "TCKimlikNo");
                calisan.Unvan = Komut.StringGetir(sdr, "Unvan");
                calisan.Parola = Komut.StringGetir(sdr, "Parola");
                int calisanTipi = Komut.Int16Getir(sdr, "CalisanTipi");
                calisan.CalisanTipi = (SISVarliklar1.Calisan.CalisanTipleri)calisanTipi;
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                calisan = null;
                
            }
            return calisan;
        }
        public static bool Kaydet(SISVarliklar1.Calisan calisan)
        {
            string spAdi = "prCalisanYeniKaydet";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@tCKimlikNo", calisan.TCKimlikNo);
            k.ParametreEkle("@ad",calisan.Ad);
            k.ParametreEkle("@soyad",calisan.Soyad);
            k.ParametreEkle("@unvan",calisan.Unvan);
            k.ParametreEkle("@ePosta",calisan.Eposta);
            k.ParametreEkle("@cepTel",calisan.CepTel);
            k.ParametreEkle("@evTel",calisan.EvTel);
            k.ParametreEkle("@parola",calisan.Parola);
            k.ParametreEkle("@calisanTipi",calisan.CalisanTipi);
            k.ParametreEkleOut("@calisanNo",SqlDbType.Int,0);
            etkilenen = k.Islet();
            if (etkilenen>0)
            {
                calisan.No = k.OutParametreDegeriGetir("@calisanNo");

            }
            k.Temizle();
            return etkilenen > 0;
        }
        public static bool Guncelle(SISVarliklar1.Calisan calisan)
        {
            string spAdi = "prCalisanGuncelle";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@tCKimlikNo", calisan.TCKimlikNo);
            k.ParametreEkle("@ad", calisan.Ad);
            k.ParametreEkle("@soyad", calisan.Soyad);
            k.ParametreEkle("@unvan", calisan.Unvan);
            k.ParametreEkle("@ePosta", calisan.Eposta);
            k.ParametreEkle("@cepTel", calisan.CepTel);
            k.ParametreEkle("@evTel", calisan.EvTel);
            k.ParametreEkle("@parola", calisan.Parola);
            k.ParametreEkle("@calisanTipi", calisan.CalisanTipi);
            k.ParametreEkle("@calisanNo", calisan.No);
            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen > 0;
        }
        public static SISVarliklar1.Calisan[] CalisanlariListele(string ad,string soyad)
        {
            string spAdi = "prCalisanlariListele";
            List<SISVarliklar1.Calisan> calisanlar = new List<SISVarliklar1.Calisan>();
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@ad", ad);
            k.ParametreEkle("@soyad", soyad);
            SqlDataReader sdr=k.IsletReader();
            while (sdr.Read())
            {
                SISVarliklar1.Calisan calisan = CalisanBilgileriYukle(sdr);
                calisanlar.Add(calisan);
            }
            sdr.Close();
            k.Temizle();
            return calisanlar.ToArray();
        }
        public static bool ParolaDegistir(int calisanNo,string yeniParola)
        {
            string spAdi = "prCalisanParolaDegistir";
            bool sonuc = false;
            Komut k=new Komut(spAdi);
            k.ParametreEkle("@calisanNo", calisanNo);
            k.ParametreEkle("@parola",yeniParola);
            sonuc = k.IsletBool();
            k.Temizle();
            return sonuc;
        }
        public static bool ParolaSifirla(string ePosta,string parola)
        {
            string spAdi = "prCalisanParolaSıfırla";
            bool sonuc =false;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@ePosta", ePosta);
            k.ParametreEkle("@parola", parola);
            sonuc = k.IsletBool();
            k.Temizle();
            return sonuc;
        }
        public static SISVarliklar1.Calisan[] UzmanlariListele()
        {
            string spAdi = "prCalisanUzmanlarıListele";
            List<SISVarliklar1.Calisan> calisanlar = new List<SISVarliklar1.Calisan>();
            Komut k = new Komut(spAdi);
            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                SISVarliklar1.Calisan calisan = CalisanBilgileriYukle(sdr);
                calisanlar.Add(calisan);
            }
            sdr.Close();
            k.Temizle();
            return calisanlar.ToArray();
        }
    }
}
