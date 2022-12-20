using System.Text.Json;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Arayuz
{
    public class BlokArayuzu
    {
        // madenci rastgele seçilecek
        private readonly Random rastgele;

        public BlokArayuzu()
        {
            rastgele = new Random();
            Ilklendir();
            Console.WriteLine("......Blok başlatıldı.");
        }

        private void Ilklendir()
        {
            var bloklar = ServisHavuzu.VeritabaniServisi.BlokVT.HepsiniGetir();

            // Genesis bloğu yarat
            if (bloklar.Count() < 1) GenesisBlokOlustur();
        }

        /// <summary>
        /// Blockchain'deki ilk blok olan genesis bloğu oluştur.
        /// </summary>
        public void GenesisBlokOlustur()
        {
            var baslangicZamani = DateTime.UtcNow.Millisecond;

            // Genesis'in 2022'de başlayacağını varsayın
            var genesisTicks = new DateTime(2022, 10, 28).Ticks;
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long zamanDamgasi = (genesisTicks - epochTicks) / TimeSpan.TicksPerSecond;

            // genesis bloğu için yaratıcıyı ilk Genesis Hesabı ile belirledik
            var genesisHesaplari = ServisHavuzu.ArayuzServisi.Hesap.GenesisHesaplariGetir();
            var dugumHesapAdresi = ServisHavuzu.CuzdanServisi._cuzdan.AdresGetir();

            // genesis işlemi oluştur
            var genesisIslemleri = ServisHavuzu
                .ArayuzServisi.Islem.GenesisIslemOlustur();
            var blok = new Blok
            {
                Yukseklik = 1,
                ZamanDamgasi = zamanDamgasi,
                OncekiKarma = "-",
                Islemler = JsonSerializer.Serialize(genesisIslemleri),
                Dogrulayici = dugumHesapAdresi,
                Versiyon = 1,
                IslemAdedi = genesisIslemleri.Count,
                ToplamTutar = Hizmetler.ToplamTutarGetir(genesisIslemleri),
                ToplamOdul = Hizmetler.ToplamUcretGetir(genesisIslemleri),
                MerkleKoku = MerkleKokOlustur(genesisIslemleri),
                DogrulayiciBakiye = 0,//ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(dugumHesapAdresi).Bakiye,
                Zorluk = 1,
                Nonce = 1
            };

            var blokKarma = BlokKarmaGetir(blok);
            blok.Karma = blokKarma;
            blok.Imza = ServisHavuzu.CuzdanServisi._cuzdan.Imzala(blokKarma);

            // Blok boyutu
            blok.Boyut = JsonSerializer.Serialize(blok).Length;

            // oluşturulma süresi
            var bitisZamani = DateTime.UtcNow.Millisecond;
            blok.InsaSuresi = (bitisZamani - baslangicZamani);

            // Hesap tablosunu güncelle
            ServisHavuzu.ArayuzServisi.Hesap.GenesisBakiyeGucelle(genesisIslemleri);

            // blokchain'e genesis bloğu ekle
            ServisHavuzu.VeritabaniServisi.BlokVT.Ekle(blok);
        }

        /// <summary>
        /// Yeni Blok oluştur
        /// </summary>
        /// <param name="hisse"></param>
        public void Yeni(Hisse hisse)
        {
            var baslangicZamani = DateTime.UtcNow.Millisecond;
            var cuzdan = ServisHavuzu.CuzdanServisi._cuzdan;

            // uykudan önceki son bloğu al
            var sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
            var siradakiYukseklik = sonBlok.Yukseklik + 1;
            var oncekiKarma = sonBlok.Karma;

            var islemler = ServisHavuzu.ArayuzServisi.Islem.BasimIcinHavuzdanIslemleriGetir(siradakiYukseklik);
            var hissedarAdresi = hisse.Adres;
            double hissedarBakiyesi = 0;
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(hissedarAdresi);
            if (hesap != null) hissedarBakiyesi = hesap.Bakiye;
            var zamanDamgasi = Hizmetler.ZamanGetir();

            if(islemler != null && islemler.Count> 0)
            {
				foreach (var islem in islemler)
				{
                    islem.Yukseklik = siradakiYukseklik;
				}
			}
            
            var blok = new Blok()
            {
                Yukseklik = siradakiYukseklik,
                ZamanDamgasi = zamanDamgasi,
                OncekiKarma = oncekiKarma,
                Islemler = JsonSerializer.Serialize(islemler),
                Zorluk = 1, //ZorlukGetir(),
                Dogrulayici = hissedarAdresi,
                Versiyon = Sabitler.VERSIYON, 
                IslemAdedi = islemler.Count,
                ToplamTutar = Hizmetler.ToplamTutarGetir(islemler),
                ToplamOdul = Hizmetler.ToplamUcretGetir(islemler),
                MerkleKoku = MerkleKokOlustur(islemler),
                DogrulayiciBakiye = hissedarBakiyesi,
                Nonce = rastgele.Next(100000),
            };

            var blokKarma = BlokKarmaGetir(blok);
            blok.Karma = blokKarma;
            blok.Imza = ServisHavuzu.CuzdanServisi._cuzdan.Imzala(blokKarma);


            // Blok boyutu
            blok.Boyut = JsonSerializer.Serialize(blok).Length;

            // inşa süresini al
            var endTimer = DateTime.UtcNow.Millisecond;
            blok.InsaSuresi = (endTimer - baslangicZamani);


            ServisHavuzu.ArayuzServisi.Hesap.BakiyeGuncelle(islemler);

            // havuzu işlemler vt'sine taşı
            ServisHavuzu.ArayuzServisi.Islem.TopluEkle(islemler);

            // işlem havuzunu boşalt
            ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.HepsiniSil();

            // vt'ye blok ekle
            ServisHavuzu.VeritabaniServisi.BlokVT.Ekle(blok);

            Hizmetler.BlokYazdir(blok);

            // bloğu yayınla/duyur
            Task.Run(() => ServisHavuzu.EstenEseServis.BlokYayinla(blok));

        }

        private string BlokKarmaGetir(Blok blok)
        {
            var strSum =
                blok.Versiyon +
                blok.OncekiKarma +
                blok.MerkleKoku +
                blok.ZamanDamgasi +
                blok.Zorluk +
                blok.Dogrulayici;
            return Hizmetler.KarmaUret(strSum);
        }

        private string MerkleKokOlustur(List<Islem> txns) =>
            Hizmetler.MerkleKokYarat(txns.Select(_ => _.Karma).ToArray());


        /// <summary>
        /// Eşten bir blok aldığınızda, bunu DB'ye eklemeden önce doğrulayın
        /// </summary>
        /// <param name="blok"></param>
        /// <returns></returns>
        public bool BlokGecerliMi(Blok blok)
        {
            var sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();

            // blok yüksekliğini önceki ile karşılaştır
            if (blok.Yukseklik != (sonBlok.Yukseklik + 1)) return false;

            // blok karma'sını önceki blok karması ile karşılaştır
            if (blok.OncekiKarma != sonBlok.Karma) return false;

            //karmayı doğrula
            if (blok.Karma != BlokKarmaGetir(blok)) return false;

            //zaman damgasını karşılaştır
            if (blok.ZamanDamgasi <= sonBlok.ZamanDamgasi) return false;

            return true;
        }
    }
}
