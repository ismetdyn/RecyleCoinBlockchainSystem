using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Arayuz
{
    public class HesapArayuzu
    {
        public HesapArayuzu() =>
            Console.WriteLine(".........Hesap başlatıldı.");

        public Hesap AdresIleGetir(string adres) =>
            ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(adres);
        

        /// <summary>
        /// Genesis hesabının başlangıç ​​bakiyesi var
        /// </summary>
        /// <returns></returns>
        public List<Hesap> GenesisHesaplariGetir()
        {
            // TODO: GENESS HESAPLARI URET
            var zamanDamgasi = Hizmetler.ZamanGetir();
            var list = new List<Hesap>();

            var genesisHesap1 = new Hesap()
            {
                Adres = Sabitler.GENESIS_HESAP1_ADRES,
                GenelAnahtar = Sabitler.GENESIS_HESAP1_GENEL_ANAHTAR,
                Bakiye = 2000000000,
                IslemAdedi = 0,
                Yaratildi = zamanDamgasi,
                Guncellendi = zamanDamgasi,
            };

            var genesisHesap2 = new Hesap()
            {
                Adres = Sabitler.GENESIS_HESAP2_ADRES,
                GenelAnahtar = Sabitler.GENESIS_HESAP2_GENEL_ANAHTAR,
                Bakiye = 3000000000,
                IslemAdedi = 0,
                Yaratildi = zamanDamgasi,
                Guncellendi = zamanDamgasi
            };
            ServisHavuzu.VeritabaniServisi.HesapVT.Ekle(genesisHesap1);
            ServisHavuzu.VeritabaniServisi.HesapVT.Ekle(genesisHesap2);
            list.Add(genesisHesap1);
            list.Add(genesisHesap2);
            return list;
        }

        /// <summary>




        /// <summary>
        /// Bakiye guncelle
        /// </summary>
        /// <param name="islemler"></param>
        public void BakiyeGuncelle(List<Islem> islemler)
        {
            foreach (var islem in islemler)
            {
                BakiyedenDus(
                    islem.Gonderen,
                    islem.Tutar,
                    islem.GenelAnahtar);
                BakiyeyeEkle(islem.Alici, islem.Tutar);
            }
        }
        
        
        /// Bakiyeye tutar ekle
        /// </summary>
        /// <param name="kime"></param>
        /// <param name="tutar"></param>
        public void BakiyeyeEkle(string kime, double tutar)
        {
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(kime);
            if(hesap is null)
            {
                var yeniHesap = new Hesap
                {
                    Adres = kime,
                    Bakiye = tutar,
                    IslemAdedi = 1,
                    Yaratildi = Hizmetler.ZamanGetir(),
                    Guncellendi = Hizmetler.ZamanGetir(),
                    GenelAnahtar = "_"
                };
                ServisHavuzu.VeritabaniServisi.HesapVT.Ekle(yeniHesap);
            }
            else
            {
                hesap.Bakiye += tutar;
                hesap.IslemAdedi += 1;
                hesap.Guncellendi = Hizmetler.ZamanGetir();
                ServisHavuzu.VeritabaniServisi.HesapVT.Guncelle(hesap);
            }
        }

        /// <summary>
        /// Bakiyeden düş
        /// </summary>
        /// <param name="kimden"></param>
        /// <param name="tutar"></param>
        /// <param name="genelAnahtar"></param>
        public void BakiyedenDus(string kimden, double tutar, string genelAnahtar)
        {
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(kimden);
            if (hesap is null)
            {
                hesap = new Hesap
                {
                    Adres = kimden,
                    Bakiye = -tutar,
                    IslemAdedi = 1,
                    Yaratildi = Hizmetler.ZamanGetir(),
                    Guncellendi = Hizmetler.ZamanGetir(),
                    GenelAnahtar = genelAnahtar
                };

                ServisHavuzu.VeritabaniServisi.HesapVT.Ekle(hesap);
            }
            else
            {
                hesap.Bakiye -= tutar;
                hesap.IslemAdedi += 1;
                hesap.GenelAnahtar = genelAnahtar;
                hesap.Guncellendi = Hizmetler.ZamanGetir();
                ServisHavuzu.VeritabaniServisi.HesapVT.Guncelle(hesap);
            }
        }


        /// <summary>
        /// Genesis Hesap Bakiyesini Güncelle
        /// </summary>
        /// <param name="islemler"></param>
        public void GenesisBakiyeGucelle(List<Islem> islemler)
        {
            foreach (var islem in islemler)
                BakiyeyeEkle(islem.Alici, islem.Tutar);
        }
    }
}
