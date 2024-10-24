using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SISWin
{
    public class Yardimci
    {
        private const string V = "\\SISWin_Hata_";
        public static int KullaniciNo = 0;

        public static void HataKaydet(Exception ex)
        {
            //Hata işletim sisteminin olay günlüğüne yazılıyor
            string dosyaAdi = Environment.CurrentDirectory + V + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
        }
    }
}
namespace SISVeriErisimKatmani
{
    public class Yardimci
    {
        private const string V = "\\SISVeriErisimKatmani_Hata_";

        public static void HataKaydet(Exception ex)
        {
            //hata işletim sisteminin olay günlüğüne yazılıyor
            string dosyaAdi = Environment.CurrentDirectory + V + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());

        }
    }
}
