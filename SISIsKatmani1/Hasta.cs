using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISIsKatmani1
{
    public class Hasta
    {
        public static int Kaydet(SISVarliklar1.Hasta hasta)
        {
            bool sonuc = false;
            if (hasta.No>0)
            {
                sonuc = SISVeriErişimKatmani1.Hasta.Guncelle(hasta);
            }
            else
            {
                sonuc = SISVeriErişimKatmani1.Hasta.Kaydet(hasta);
            }
            if (sonuc)
            {
                return hasta.No;
            }
            else
            {
                return 0;
            }
        }
        public static SISVarliklar1.Hasta[] HastalariListele(string ad,string soyad)
        {
            SISVarliklar1.Hasta[] hastalar = null;
            hastalar = SISVeriErişimKatmani1.Hasta.HastalariListele(ad, soyad);
            return hastalar;
        }
        public static SISVarliklar1.Hasta HastaGetir(int hastaNo)
        {
            SISVarliklar1.Hasta hasta = null;
            hasta = SISVeriErişimKatmani1.Hasta.HastaGetir(hastaNo);
            return hasta;
        }
    }
}
