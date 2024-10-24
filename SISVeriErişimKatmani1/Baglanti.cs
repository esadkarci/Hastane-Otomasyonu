﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SISVeriErişimKatmani1
{
    public class Baglanti
    {
        static string baglantiMetni = "Server=.;Database=SIS; Integrated Security=SSPI";
        ///<summary>
        ///Yeni bir bağlantı oluşturularak yollanıyor.
        ///</summary>
        ///<returns>Yeni bağlantı.</returns>
        public static SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            return baglanti;
        }
        ///<summary>
        ///Mevcut bağlantı sonlandırılır.
        /// </summary>
        /// <param name="baglanti">Sonlandırılacak bağlantı.</param>
        public static void BaglantiSonlandir(SqlConnection baglanti)
        {
            if (baglanti == null)
            {
                return;
            }
            if (baglanti.State != ConnectionState.Closed && baglanti.State != ConnectionState.Broken)
            {
                baglanti.Close();
            }
            baglanti.Dispose();
        }
    }
}
