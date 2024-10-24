using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISIsKatmanı
{
    internal class Calisan
    {
        public static int KullaniciGirisiniDoğrula(string ePosta,string parola)
        {
            int sonuc = 0;  //sonuc değeri,servis çağrılıyor,Veri erişim katmanından çalışan numarası alınıyor
            sonuc = SISVeriErisimKatmani.Calisan.KullanıcıGirisiniDogrula(ePosta, parola);
            return sonuc;
        }
    }
}
