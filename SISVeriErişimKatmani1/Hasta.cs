using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISVeriErişimKatmani1
{
    public class Hasta
    {
        public static bool Kaydet(SISVarliklar1.Hasta hasta)
        {
            string spAdi = "prHastaYeniKaydet";
            int etkilenen = 0;
            Komut k=new Komut(spAdi);
            k.ParametreEkle("@tCKimlikNo",hasta.TCKimlikNo);
            k.ParametreEkle("@ad",hasta.Ad);
            k.ParametreEkle("@soyad",hasta.Soyad);
            k.ParametreEkle("@dogumTarihi",hasta.DogumTarihi);
            k.ParametreEkle("@cinsiyeti",hasta.Cinsiyeti);
            k.ParametreEkle("@ePosta",hasta.Eposta);
            k.ParametreEkle("@cepTel",hasta.CepTel);
            k.ParametreEkle("@evTel",hasta.EvTel);
            k.ParametreEkle("@adres",hasta.Adres);
            k.ParametreEkleOut("@hastaNo",SqlDbType.Int,0);
            etkilenen = k.Islet();
            if (etkilenen>0)
            {
                hasta.No = k.OutParametreDegeriGetir("@hastaNo");
            }
            k.Temizle();
            return etkilenen > 0;
        }
        public static bool Guncelle(SISVarliklar1.Hasta hasta)
        {
            string spAdi = "prHastaGuncelle";
            int etkilenen = 0;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@tCKimlikNo", hasta.TCKimlikNo);
            k.ParametreEkle("@ad", hasta.Ad);
            k.ParametreEkle("@soyad", hasta.Soyad);
            k.ParametreEkle("@dogumTarihi", hasta.DogumTarihi);
            k.ParametreEkle("@cinsiyeti", hasta.Cinsiyeti);
            k.ParametreEkle("@ePosta", hasta.Eposta);
            k.ParametreEkle("@cepTel", hasta.CepTel);
            k.ParametreEkle("@evTel", hasta.EvTel);
            k.ParametreEkle("@adres", hasta.Adres);
            k.ParametreEkle("@hastaNo", hasta.No);
            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen > 0;
        }
        public static SISVarliklar1.Hasta[] HastalariListele(string ad,string soyad)
        {
            string spAdi = "prHastalariListele";
            List<SISVarliklar1.Hasta> hastalar = new List<SISVarliklar1.Hasta>();
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@ad", ad);
            k.ParametreEkle("@soyad", soyad);

            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                SISVarliklar1.Hasta hasta = HastaBilgikeriYukle(sdr);
                hastalar.Add(hasta);
                
            }
            sdr.Close();
            k.Temizle();
            return hastalar.ToArray();
        }

        private static SISVarliklar1.Hasta HastaBilgikeriYukle(SqlDataReader sdr)
        {
            SISVarliklar1.Hasta hasta = new SISVarliklar1.Hasta();
            hasta.No = Komut.İnt32Getir(sdr, "HastaNo");
            hasta.TCKimlikNo = Komut.StringGetir(sdr, "TCKimlikNo");
            hasta.Ad = Komut.StringGetir(sdr, "Ad");
            hasta.Soyad = Komut.StringGetir(sdr, "Soyad");
            hasta.DogumTarihi = Komut.TarihGetir(sdr, "DogumTarihi");
            hasta.Cinsiyeti = Komut.StringGetir(sdr,"Cinsiyeti");
            hasta.Eposta = Komut.StringGetir(sdr, "Eposta");
            hasta.CepTel = Komut.StringGetir(sdr, "CepTel");
            hasta.EvTel = Komut.StringGetir(sdr, "EvTel");
            hasta.Adres = Komut.StringGetir(sdr, "Adres");
            return hasta;
        }
        public static SISVarliklar1.Hasta HastaGetir(int hastaNo)
        {
            string spAdi = "prHastaGetir";
            SISVarliklar1.Hasta hasta = null;
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);
            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                hasta = HastaBilgikeriYukle(sdr);
            }
            sdr.Close();
            k.Temizle();
            return hasta;
        }
    }
}
