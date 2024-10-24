using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVarliklar
{
    public class Calisan : Kisi
    {
        public enum CalisanTipleri
        {
            SistemYoneticisi,
            Sekreter,
            Uzman
        }
        #region Local Variables
        private string unvan = String.Empty;
        private string parola = String.Empty;
        private CalisanTipleri calisanTipi;
        #endregion


        #region Public Properties
        public string Unvan
        {
            get { return unvan; }
            set { unvan = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }
        /// <summary>
        ///  0: sekreter, 1:uzman
        /// </summary>
        public CalisanTipleri CalisanTipi
        {
            get { return calisanTipi; }
            set { calisanTipi = value; }
        }



        #endregion
        public override string GoruntuMetni
        {
            get
            {
                if (calisanTipi == CalisanTipleri.Uzman)
                {
                    return string.Format("{0} {1} ({2})", base.ad, base.soyad, unvan);
                }
                else
                {
                    return base.GoruntuMetni;
                }
            }
        }
    }
}

