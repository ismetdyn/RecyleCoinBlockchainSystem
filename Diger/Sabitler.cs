using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoinServer.Diger
{
    public class Sabitler
    {
        #region Genesis_Hesaplar
        // genesis hesap 1
        public const string GENESIS_HESAP1_ADRES = "9SBqYME6T5trNHXqdsYPMPha4yWQbzxd4DPjJBR7KG9A";
        public const string GENESIS_HESAP1_GENEL_ANAHTAR = "02c51f708f279643811af172b9f838aabb2cb4c90b683da9c5d4b81d70f00e9af2";
        protected internal const string GENESİS_HESAP1_MNEMONIC = "live uniform pudding know thumb hand deposit critic relief asset demand barrel";

        // genesis hesap 2
        public const string GENESIS_HESAP2_ADRES = "3pXA6G3o2bu3Mbp9k2NDfXGWPuhCMn4wvZeTAFCf4N5r";
        public const string GENESIS_HESAP2_GENEL_ANAHTAR = "03155bbe7fa31d0ebfd779a50a02c1d9444bbf79deb90e1725216d5e8786c632f8";
        protected internal const string GENESİS_HESAP2_MNEMONIC = "carbon snack lab junk moment shiver gas dry stem real scale cannon";
        #endregion


        public const int VERSIYON = 0;
        public const double VARSAYILAN_ISLEM_UCRETI = 0.001;
        public const double VARSAYILAN_COINBASE_ISLEM_UCRETI = 0.00001;
        public const double COIN_ODULU = 0.001f;
        
        public const string TBL_BLOKLAR = "tbl_bloklar";
        public const string TBL_ISLEMLER = "tbl_islemler";
        public const string TBL_ISLEM_HAVUZU = "tbl_islem_havuzu";
        public const string TBL_HISSELER = "tbl_hisseler";
        public const string TBL_ESLER = "tbl_esler";
        public const string TBL_HESAPLAR = "tbl_hesaplar";
        public const string ISLEM_TIP_HISSE = "Hisse";
        public const string ISLEM_TIP_AKTARIM = "Aktarim";
        public const string ISLEM_TIP_DOGRULAYICI_UCRETI = "Dogrulayici_Ucreti";

        public const string ISLEM_DURUM_BASARILI = "Basarili";
        public const string ISLEM_DURUM_BASARISIZ = "Basarisiz";

        public const string MESAJ_TIP_ENV = "ENVANTER";
        public const string MESAJ_TIP_BLOCKLARI_GETIR = "BLOCKLARI_GETIR";
        public const string MESAJ_TIP_VERI_GETIR = "VERI_GETIR";
        public const string MESAJ_TIP_DURUM = "NODE_DURUM";
        public const string MESAJ_AYRAC = "||";
        public const string MESAJ_TIP_BLOK= "BLOK";
        public const string MESAJ_TIP_ISLEM= "ISLEM";
        public const int ISLEM_ESIGI = 5;
        public const int BLOK_URETIM_ARALIGI = 30;
        public const int ZORLUK_AYARLAMA_ARALIGI = 10;
        public const string MESAJ_TIP_ISLEMLERI_TEMIZLE = "ISLMELERI_TEMIZLE";
    }
}
