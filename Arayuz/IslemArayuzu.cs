using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Arayuz
{
    public class IslemArayuzu
    {
        public IslemArayuzu() => 
            Console.WriteLine("...... İşlem başlatıldı.");

        /// <summary>
        /// Toplu işlem ekle
        /// </summary>
        /// <param name="islemler"></param>
        /// <returns></returns>
        public bool TopluEkle(List<Islem> islemler) =>
            ServisHavuzu.VeritabaniServisi.IslemVT.TopluEkle(islemler);
        

        public List<Islem> GenesisIslemOlustur()
        {
            var genesisIslemleri = new List<Islem>();
            var zamanDamgasi = Hizmetler.ZamanGetir();
            var hesaplar = ServisHavuzu.ArayuzServisi.Hesap.GenesisHesaplariGetir();

            for (int i = 0; i < hesaplar.Count; i++)
            {
                var yeniIslem = new Islem
                {
                    ZamanDamgasi = zamanDamgasi,
                    Gonderen = hesaplar[i].Adres,
                    Alici = hesaplar[i].Adres,
                    Tutar = hesaplar[i].Bakiye,
                    Ucret = 0,
                    Yukseklik = 1,
                    GenelAnahtar = hesaplar[i].GenelAnahtar
                };

                var islemKarma = KarmaGetir(yeniIslem);
                yeniIslem.Karma = islemKarma;
                if( i == 0) yeniIslem.Imza = ServisHavuzu.CuzdanServisi.Genesis1Imza(islemKarma);
                else if( i == 1) yeniIslem.Imza = ServisHavuzu.CuzdanServisi.Genesis2Imza(islemKarma);

                genesisIslemleri.Add(yeniIslem);
            }
            return genesisIslemleri;
        }

        public Islem ExplorerIslemOlustur(Islem islem)
        {
			var genesisHesaplar = ServisHavuzu.ArayuzServisi.Hesap.GenesisHesaplariGetir();
            var zamanDamgasi = Hizmetler.ZamanGetir();
            long yukseklik = 0;
            var sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
            if (sonBlok != null) yukseklik = sonBlok.Yukseklik + 1;
            islem.ZamanDamgasi = zamanDamgasi;
            islem.IslemTipi = "Explorer";
            islem.Ucret = Sabitler.VARSAYILAN_ISLEM_UCRETI;
            islem.Yukseklik = yukseklik;
            
            if(genesisHesaplar != null && genesisHesaplar.Count > 0)
            {
                if (genesisHesaplar[0].Bakiye > islem.Tutar)
                {
                    islem.Gonderen = genesisHesaplar[0].Adres;
                    islem.GenelAnahtar = genesisHesaplar[0].GenelAnahtar;
                    islem.Karma = KarmaGetir(islem);
                    islem.Imza = ServisHavuzu.CuzdanServisi.Genesis1Imza(islem.Karma);
				}
                else if (genesisHesaplar[1].Bakiye > islem.Tutar)
                {
                    islem.Gonderen = genesisHesaplar[1].Adres;
                    islem.GenelAnahtar = genesisHesaplar[1].GenelAnahtar;
                    islem.Karma = KarmaGetir(islem);
                    islem.Imza = ServisHavuzu.CuzdanServisi.Genesis2Imza(islem.Karma);
				}
			}
            return islem;
		}

        /// <summary>
        /// İşlem karmasını al
        /// </summary>
        /// <param name="islem"></param>
        /// <returns></returns>
        private string KarmaGetir(Islem islem)
        {
            var veri = $"{islem.ZamanDamgasi}{islem.Gonderen}{islem.Tutar}{islem.Ucret}{islem.Alici}";
            return Hizmetler.KarmaUret(Hizmetler.KarmaUret(veri));
        }

        public double BakiyeGetir(string adres)
        {
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(adres);
            if (hesap == null) return 0;

            return hesap.Bakiye;
        }

        public List<Islem> BasimIcinHavuzdanIslemleriGetir(long weight)
        {
            // havuzdan işlemleri al
            var havuzIslemleri = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.HepsiniGetir();
            var islemler = new List<Islem>();

            /**
             * Doğrulayıcı, Blockchain'deki toplam parayı değişmeden tutmak için
             * genesis hesabından jeton ödülü alacak
             **/
            var genesisHesap1 = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(Sabitler.GENESIS_HESAP1_ADRES);
            var genesisHesap2 = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(Sabitler.GENESIS_HESAP2_ADRES);

            var agIslemi = new Islem
            {
                ZamanDamgasi = Hizmetler.ZamanGetir(),
                Alici = ServisHavuzu.CuzdanServisi._cuzdan.AdresGetir(),
                IslemTipi = Sabitler.ISLEM_TIP_DOGRULAYICI_UCRETI,
                Tutar = Sabitler.COIN_ODULU,
                Ucret = 0,
                Yukseklik = weight,
                Imza = "-",
                Gonderen = "-",
                GenelAnahtar = "-"
            };

            if (genesisHesap1 != null && genesisHesap1.Bakiye > Sabitler.COIN_ODULU)
            {
                agIslemi.Gonderen = genesisHesap1.Adres;
                agIslemi.GenelAnahtar = ServisHavuzu.CuzdanServisi.Genesis1GenelAnahtarGetir().ToString();
            }
            else if (genesisHesap2 != null && genesisHesap2.Bakiye > Sabitler.COIN_ODULU)
            {
                agIslemi.Gonderen = genesisHesap2.Adres;
                agIslemi.GenelAnahtar = ServisHavuzu.CuzdanServisi.Genesis2GenelAnahtarGetir().ToString();
            }
            
            // coinbase işlemi işlemler listesine ekle
            agIslemi.Karma = Hizmetler.IslemKarmasiOlustur(agIslemi);
            if (genesisHesap1 != null && agIslemi.Gonderen == genesisHesap1.Adres) 
                agIslemi.Imza = ServisHavuzu.CuzdanServisi.Genesis1Imza(agIslemi.Karma);
            else if(genesisHesap2 != null && agIslemi.Gonderen == genesisHesap2.Adres)
                agIslemi.Imza = ServisHavuzu.CuzdanServisi.Genesis2Imza(agIslemi.Karma);

            islemler.Add(agIslemi);
            
            if (havuzIslemleri.Any()) islemler.AddRange(havuzIslemleri);
            return islemler;
        }
    }
}
