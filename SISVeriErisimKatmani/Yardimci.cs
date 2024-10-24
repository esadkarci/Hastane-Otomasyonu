using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SISVeriErisimKatmani
{
    public class Yardimci
    {
        private const string V =  "\\SISVeriErisimKatmani_Hata_";

        public static void HataKaydet(Exception ex)
        {
            //hata işletim sisteminin olay günlüğüne yazılıyor
            string dosyaAdi=Environment.CurrentDirectory+ V + Guid.NewGuid() + ".txt";
            File.WriteAllText(dosyaAdi, ex.ToString());
            
        }
    }
}
