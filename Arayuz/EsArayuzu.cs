using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Arayuz
{
    public class Inventory
    {
        public string Tip { get; set; }
        public IList<string> Items { get; set; }
    }

    public class EsArayuzu
    {
        public string DugumAdresi {  get; set; }
        public List<Es> mevcutEsler { get; set; }

        public EsArayuzu()
        {
            Ilklendir();
            Console.WriteLine("..... Eş başlatıldı.");
        }

        public void Ilklendir()
        {
            DugumAdresi = DotNetEnv.Env.GetString("DUGUM_ADRESI");
            var bilinenEsler = ServisHavuzu.VeritabaniServisi.EsVT.HepsiniGetir();
            if(bilinenEsler.Count() < 1)
            {
                mevcutEsler = new List<Es>();
                var onYukluEsler = DotNetEnv.Env.GetString(
                    "ONYUKLU_ESLER").Replace(" ","");
                var geciciEsler = onYukluEsler.Split(",");

                for (int i = 0; i < geciciEsler.Length; i++)
                {
                    var yeniEs = new Es
                    {
                        Adres = geciciEsler[i],
                        OnyukluMu = true,
                        ErisilebilirMi = false,
                        SonErisim = Hizmetler.ZamanGetir()
                    };

                    ServisHavuzu.VeritabaniServisi.EsVT.EkleGuncelle(yeniEs);
                    mevcutEsler.Add(yeniEs);
                }
            }
        }

        public List<Es> BilinenEsleriGtir() =>
            ServisHavuzu.VeritabaniServisi.EsVT.HepsiniGetir();

        public EsDurum DugumDurumuGetir()
        {
            var sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
            var durum = new EsDurum
            {
                Versiyon = Sabitler.VERSIYON,
                Yukseklik = sonBlok.Yukseklik,
                Adres = DugumAdresi,
                Karma = sonBlok.Karma
            };

			durum.BilinenEsler.AddRange(BilinenEsleriGtir());
            return durum;
        }

        public void Ekle(Es es) =>
            ServisHavuzu.VeritabaniServisi.EsVT.EkleGuncelle(es);
    }
}
