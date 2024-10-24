using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISIsKatmani1
{
    public class Seans
    {
        
        public static SISVarliklar1.Seans[] UzmanSeanslariniListele(int uzmanNo)
        {
            SISVarliklar1.Seans[] seanslar = null;
            seanslar = SISVeriErişimKatmani1.Seans.UzmanSeanslariniListele(uzmanNo);
            return seanslar;
        }
        public static bool IptalEt(SISVarliklar1.Seans seans)
        {
            bool sonuc = false;
            sonuc = SISVeriErişimKatmani1.Seans.IptalEt(seans);
            return sonuc;
        }
        public static SISVarliklar1.Seans SonRandevuBilgisiGetir(int hastaNo)
        {
            SISVarliklar1.Seans seans = null;
            seans = SISVeriErişimKatmani1.Seans.SonSeansBilgisiGetir(hastaNo);
            return seans;
        }
        public static SISVarliklar1.Seans SonSeansBilgisiGetir(int hastaNo)
        {
            SISVarliklar1.Seans seans = null;
            seans = SISVeriErişimKatmani1.Seans.SonSeansBilgisiGetir(hastaNo);
            return seans;
        }
        public static bool RandevuIptalEt(int seansNo)
        {
            bool sonuc = false;
            sonuc = SISVeriErişimKatmani1.Seans.RandevuIptalEt(seansNo);
            return sonuc;
        }
        public static bool RandevuKaydet(int seansNo, int hastaNo)
        {
            bool sonuc = false;
            sonuc = SISVeriErişimKatmani1.Seans.RandevuKaydet(seansNo, hastaNo);
            return sonuc;
        }
        public static SISVarliklar1.Seans[] HastaSeanslariniListele(int hastaNo)
        {
            SISVarliklar1.Seans[] seanslar = null;
            seanslar = SISVeriErişimKatmani1.Seans.HastaSeanslariniListele(hastaNo);
            return seanslar;
        }
        public static bool NotGuncelle(int seansNo, string seansNotu)
        {
            bool sonuc = false;
            sonuc = SISVeriErişimKatmani1.Seans.NotGuncelle(seansNo, seansNotu);
            return sonuc;
        }

        public static int Kaydet(SISVarliklar1.Seans seans)
        {
            throw new NotImplementedException();
        }

        //public int cakismaVarMi(int uzmanNo, DateTime tarih, string baslangicSaati, string bitisSaati)
        //{

        //    bool sonuc = false;
        //    CakismaVarMi = true;
        //    cakismaVarMi = SISVeriErişimKatmani1.Seans.CakismaVarMi(seans.UzmanNo, seans.Tarih, seans.BaslangicSaati, seans.BitisSaati);
        //    if (cakismaVarMi)
        //    {
        //        return -1;//çakışma var
        //    }
        //    sonuc = SISVeriErişimKatmani1.Seans.Kaydet(seans);
        //    if (sonuc)
        //    {
        //        return seans.No;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}


    }
}
