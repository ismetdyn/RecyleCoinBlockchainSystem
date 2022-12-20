using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;

namespace RecycleCoinServer.Servisler
{
    public class BlokBasimServisi
    {
        private CancellationTokenSource gorevIptal;
        private bool bahisYapiyorMu;
        private bool blokYapiyorMu;
        private readonly Random rastgele;

        public BlokBasimServisi()
        {
            rastgele = new Random();
            bahisYapiyorMu = true;
            blokYapiyorMu = true;
        }

        public void Baslat()
        {
            // durumu diğeriyle senkronize et
            Console.WriteLine(".....Diğer eş(ler) ile Senkronizasyon durumu");
            ServisHavuzu.EstenEseServis.DurumSenkronizeEt();
            Console.WriteLine(".... Dugum Hazır.");

            Console.WriteLine("\n....Basım servisi başlatılıyor");
            gorevIptal = new CancellationTokenSource();

            /**
             * AutoHisse çalıştırma.
             * Gerçek blok zincirinde gerçek hisse işlemi için kullanıcı 
             * web sitesi veya mobil uygulama aracılığıyla hisse yapar.
             * Bu otomatik hisse işleminde bakiye ve imza doğrulaması yapmıyorum.
             **/
            Task.Run(OtomatikHisseTeklifDongusu, gorevIptal.Token);

            // Block basma(kazma) Sürecini çalıştırma
            Task.Run(BlokBasim, gorevIptal.Token);
        }

        public void Durdur()
        {
            gorevIptal.Cancel();
            Console.WriteLine("Darphane durduruldu");
        }

        public void BlokBasim()
        {
            blokYapiyorMu=true;
            Console.WriteLine("\n\n=========== DÜGÜM ÇALIŞIYOR========\n");
            Console.WriteLine(". Hesap Adresi: {0}", ServisHavuzu.CuzdanServisi._cuzdan.AdresGetir());
            Console.WriteLine(". Ağ Adresi: {0}", ServisHavuzu.ArayuzServisi.Es.DugumAdresi);
            var sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
            Console.WriteLine("- Son Blok: {0}", sonBlok.Yukseklik);
            Console.WriteLine("\n--------------Blokları doğrulamaya hazırım----------------\n");

            while (true)
            {
                var basimZamani = DateTime.UtcNow;
                if (basimZamani.Second < 3) blokYapiyorMu = false;

                if(!blokYapiyorMu && basimZamani.Second >= 45)
                {
                    blokYapiyorMu = true;

                    Console.WriteLine("\n\n==== BLOCK BASMA ZAMANI ====\n");
                    Console.WriteLine("- Time: {0}", basimZamani.Second);
                    sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
                    Console.WriteLine("- Son Blok: {0}", sonBlok.Yukseklik);

                    Console.WriteLine("\n--------------------\nBahis Lider Tablosu:");
                    Task.Run(LiderTablosu);

                    var adresim = ServisHavuzu.CuzdanServisi._cuzdan.AdresGetir();
                    var enBuyukHisse = ServisHavuzu.VeritabaniServisi.HisseVT.EnBuyukGetir();
                    if(enBuyukHisse is not null && adresim == enBuyukHisse.Adres)
                    {
                        Console.WriteLine("\n-- Haha, bir sonraki bloğun doğrulayıcısıyım!\n");
                        ServisHavuzu.ArayuzServisi.Blok.Yeni(enBuyukHisse);
                    }
                    else Console.WriteLine( "Kahretsin, bu sefer şanslı değildim.");
                    
                    Console.WriteLine("======= BLOK BASMA BİTTİ =====\n\n\n");
                }

                // 1 saniye uyuyor
                Thread.Sleep(1000);
            }
        }


        public void OtomatikHisseTeklifDongusu()
        {
            ServisHavuzu.VeritabaniServisi.HisseVT.HepsiniSil();
            while(true)
            {
                var bahisZamani = DateTime.UtcNow;
                // Block oluşturmadan önce bahisleri temizle.
                if(bahisZamani.Second < 3 )
                {
                    ServisHavuzu.VeritabaniServisi.HisseVT.HepsiniSil();
                    Console.WriteLine(".....Bahis listemi temizledim");
                    bahisYapiyorMu = false;
                    Thread.Sleep(4000);
                    bahisZamani = DateTime.UtcNow;
                }

                // Bahis yatırma, şu saniyeler(4 ila 30) arasında başlayarak
                // sınırlı bir süre içinde yapılacaktır. 
                if (!bahisYapiyorMu && bahisZamani.Second < 35)
                {
                    // Rastgele miktarla bahis yapma
                    var hisse = new Hisse
                    {
                        Adres = ServisHavuzu.CuzdanServisi._cuzdan.AdresGetir(),
                        Tutar = rastgele.Next(10, 100),
                        ZamanDamgasi = Hizmetler.ZamanGetir()
                    };
                    Console.WriteLine("{0} Şimdi {1} coin yatıracağım \n", DateTime.UtcNow, hisse.Tutar);

                    ServisHavuzu.VeritabaniServisi.HisseVT.EkleGuncelle(hisse);

                    Task.Run(() => ServisHavuzu.EstenEseServis.HisseYayinla(hisse));

                    bahisYapiyorMu = true;
                }

                // 1 saniye uyutuyoruz
                Thread.Sleep(1000);
            }
        }

        private void LiderTablosu()
        {
            var hisseListesi = ServisHavuzu.VeritabaniServisi.HisseVT.HepsiniGetir();
            foreach (var hisse in hisseListesi)
                Console.WriteLine(" {0}, {1}", hisse.Adres, hisse.Tutar);

            Console.WriteLine("-------------------------------------");
        }
    }
}
