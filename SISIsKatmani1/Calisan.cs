using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VEK = SISVeriErişimKatmani1;

namespace SISIsKatmani1
{
    public class Calisan
    {
        public static int KullaniciGirisiniDogrula(string ePosta, string parola)
        {
            int sonuc = 0;
            sonuc = VEK.Calisan.KullaniciGirisiniDogrula(ePosta, parola);
            return sonuc;
        }
        public static SISVarliklar1.Calisan CalisanGetir(int calisanNo)
        {
            SISVarliklar1.Calisan calisan = null;
            calisan = SISVeriErişimKatmani1.Calisan.CalisanGetir(calisanNo);
            return calisan;
        }
        public static int Kaydet(SISVarliklar1.Calisan calisan)
        {
            bool sonuc = false;
            if (calisan.No > 0)
            {
                sonuc = SISVeriErişimKatmani1.Calisan.Guncelle(calisan);
            }
            else
            {
                calisan.Parola = Yardimci.ParolaOlustur();
                sonuc = SISVeriErişimKatmani1.Calisan.Kaydet(calisan);
            }
            if (sonuc)
            {
                Yardimci.YeniParolaEpostasiYolla(calisan.Eposta, calisan.Parola);
                return calisan.No;
            }
            else
            {
                return 0;
            }
            




        }
        public static SISVarliklar1.Calisan[] CalisanlariListele(string ad,string soyad)
        {
            SISVarliklar1.Calisan[] calisanlar = null;
            calisanlar = SISVeriErişimKatmani1.Calisan.CalisanlariListele(ad, soyad);
            return calisanlar;
        }
        public static bool ParolaDegistir(int calisanNo,string yeniParola)
        {
            bool sonuc = false;
            sonuc = SISVeriErişimKatmani1.Calisan.ParolaDegistir(calisanNo, yeniParola);
            return sonuc;
        }
        public static bool ParolaSifirla(string ePosta,string parola)
        {
            bool sonuc = false;
            sonuc = SISVeriErişimKatmani1.Calisan.ParolaSifirla(ePosta,parola);
            return sonuc;
        }
        public static SISVarliklar1.Calisan[] UzmanlariListele()
        {
            SISVarliklar1.Calisan[] calisanlar = null;
            calisanlar = SISVeriErişimKatmani1.Calisan.UzmanlariListele();
            return calisanlar;

        }
    }
}
