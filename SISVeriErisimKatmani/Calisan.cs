using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVeriErisimKatmani
{
    internal class Calisan
    {
        public static int KullaniciGirisiniDoğrula(string ePosta,string parola)
        {
            string spAdi = "prCalisanGirisiniDoğrula";
            Komut k = new Komut(spAdi);
            k.ParametreEkle("@ePosta",ePosta);
            k.ParametreEkle("@parola", parola);

            int sonuc = k.IsletInt32();
            k.Temizle();
            return sonuc;
        }
    }
}
