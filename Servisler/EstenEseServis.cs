using Grpc.Net.Client;
using RecycleCoin.Grpc;
using static RecycleCoin.Grpc.BlokServis;
using static RecycleCoin.Grpc.EsServis;
using static RecycleCoin.Grpc.HisseServis;
using static RecycleCoin.Grpc.IslemServis;

namespace RecycleCoinServer.Servisler
{
    /// <summary>
    /// Bu sınıf blok yayınlama, işlem yayınlama, blok indirme gibi
    /// eşler arası haberleşme işlemleri içindir.
    /// </summary>
    public class EstenEseServis
    {
        public void Baslat()
        {
            Console.WriteLine(".....EstenEseServis hizmeti başlatılıyor");
            Console.WriteLine(".....EstenEseServis hizmeti hazır");
        }


        /// <summary>
        /// Mevcut esler listesindeki tüm eslere bir blok yayını yap 
        /// </summary>
        /// <param name="blok"></param>
        public void BlokYayinla(Blok blok)
        {
            var bilinenEsler = ServisHavuzu.ArayuzServisi.Es.BilinenEsleriGtir();
            var dugumAdresi = ServisHavuzu.ArayuzServisi.Es.DugumAdresi;

            Parallel.ForEach(bilinenEsler, es =>
            {
                if (!dugumAdresi.Equals(es.Adres))
                {
                    Console.WriteLine("-- {0}' a blok yayını", es.Adres);
                    GrpcChannel kanal = GrpcChannel.ForAddress(es.Adres);
                    var blokServisi = new BlokServisClient(kanal);
                    try
                    {
                        var yanit = blokServisi.Ekle(new BlokIstek { Blok = blok});
                        if (yanit.Durum)
							Console.WriteLine("--- Başarılı.");
                        
                    }
                    catch { Console.WriteLine("Başarısız"); }
                }
            });
        }

        /// <summary>
        /// Bilinen tüm eşlere bahis yayınla
        /// </summary>
        /// <param name="hisse"></param>
        public void HisseYayinla(Hisse hisse)
        {
            var bilinenEsler = ServisHavuzu.ArayuzServisi.Es.BilinenEsleriGtir();
            var dugumAdresi = ServisHavuzu.ArayuzServisi.Es.DugumAdresi;
            Parallel.ForEach(bilinenEsler, es =>
            {
                if (!dugumAdresi.Equals(es.Adres))
                {
                    Console.WriteLine("{0} 'a bahis yayını", es.Adres);
                    GrpcChannel kanal = GrpcChannel.ForAddress(es.Adres);
                    var hisseServisi = new HisseServisClient(kanal);
                    try
                    {
                        var yanit = hisseServisi.Ekle(new HisseIstek { Hisse  = hisse});
                        if(yanit.Durum)
                            Console.WriteLine("--- Başarılı");
                    }
                    catch { Console.WriteLine("--- Başarısız"); }
                }
            });
        }


        public void IslemYayinla(Islem islem)
        {
            var bilinenEsler = ServisHavuzu.ArayuzServisi.Es.BilinenEsleriGtir();
            var dugumAdresi = ServisHavuzu.ArayuzServisi.Es.DugumAdresi;
            Parallel.ForEach(bilinenEsler, es =>
            {
                if (!dugumAdresi.Equals(es.Adres))
                {
                    Console.WriteLine("{0} 'a işlem yayını", es.Adres);
                    GrpcChannel kanal = GrpcChannel.ForAddress(es.Adres);
                    var islemServisi = new IslemServisClient(kanal);
                    try
                    {
                        var yanit = islemServisi.Al(new IslemIstek { Islem = islem });
                        if (yanit.Durum == true)
                            Console.WriteLine("--- Başarılı");
                        else
                            Console.WriteLine("--- Başarısız");
                    }
                    catch { Console.WriteLine("--- Başarısız"); }
                }
            });
        }

        /// <summary>
        /// Bilinen eşlerdeki tüm eşlerden gelen blokları senkronize eder.
        /// </summary>
        /// <param name="blokServisi"></param>
        /// <param name="sonBlokYuksekligi"></param>
        /// <param name="esYukseklik"></param>
        private void BloklariIndir(BlokServisClient blokServisi, long sonBlokYuksekligi, long esYukseklik)
        {
            var yanit = blokServisi.TabanYukseklikIleListeGetir(
                new BlokIstek { TabanYukseklik = sonBlokYuksekligi });
            List<Blok> bloklar = yanit.Bloklar.ToList();

            var sonYukseklik = 0L;
            foreach (var blok in bloklar)
            {
                try
                {
                    Console.WriteLine("===== İndirilen blok: {0}", blok.Yukseklik);
                    var durum = ServisHavuzu.VeritabaniServisi.BlokVT.Ekle(blok);
                    sonYukseklik = blok.Yukseklik;
                    Console.WriteLine("==== Başarılı");
                }
                catch { Console.WriteLine("==== Başarısız"); }

                if (sonYukseklik < esYukseklik)
                    BloklariIndir(blokServisi, sonBlokYuksekligi, esYukseklik);
				else return;
			}
        }


        /// <summary>
        /// Yeni Eş'in halihazırda veritabanında olup olmadığını
        /// kontrol etme
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        private bool YeniBirEsMi(string adres)
        {
            var bilinenEsler = ServisHavuzu.ArayuzServisi.Es.BilinenEsleriGtir();
            foreach (var es in bilinenEsler)
                if (adres == es.Adres) return true;

            return false;
        }

        /// <summary>
        /// Blok zinciri durumlarını senkronize edin, 
        /// blok yüksekliğini diğer akranlarla aynı yapın
        /// </summary>
        public void DurumSenkronizeEt()
        {
            var bilinenEsler = ServisHavuzu.ArayuzServisi.Es.BilinenEsleriGtir();
            var dugumAdresi = ServisHavuzu.ArayuzServisi.Es.DugumAdresi;

            // eş senkronizasyonu
            foreach (var es in bilinenEsler)
            {
                if (!dugumAdresi.Equals(es.Adres))
                {
                    Console.WriteLine("Durum eşle senkronize ediliyor: ", es.Adres);
                    try
                    {
                        GrpcChannel kanal = GrpcChannel.ForAddress(es.Adres);
                        var esServis = new EsServisClient(kanal);
                        var esDurum = esServis.DugumDurumuGetir(
                            new EsIstek { DugumIpAdresi = dugumAdresi });

                        // Veritabanına eş ekle
                        foreach (var yeniEs in esDurum.BilinenEsler)
                            ServisHavuzu.ArayuzServisi.Es.Ekle(yeniEs);
                    }
                    catch { }
                }
            }

            // blok senkronizasyonu
            bilinenEsler = ServisHavuzu.ArayuzServisi.Es.BilinenEsleriGtir();
            foreach (var es in bilinenEsler)
            {
                if (!dugumAdresi.Equals(es.Adres))
                {
                    try
                    {
                        GrpcChannel kanal = GrpcChannel.ForAddress(es.Adres);
                        var esServis = new EsServisClient(kanal);
                        var esDurum = esServis.DugumDurumuGetir(
                            new EsIstek { DugumIpAdresi = dugumAdresi });

                        // yerel blok yüksekliği
                        var sonBlokYukseklik =
                            ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir().Yukseklik;
                        var blokServis = new BlokServisClient(kanal);
                        if (sonBlokYukseklik < esDurum.Yukseklik)
                            BloklariIndir(blokServis, sonBlokYukseklik, esDurum.Yukseklik);
                    }
                    catch { }
                }
            }

            Console.WriteLine("---- Senkronizasyon Tamamlandı~");
        }
    }
}
