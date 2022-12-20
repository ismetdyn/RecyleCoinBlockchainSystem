using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Grpc
{
    public class HesapGrpcServis : HesapServis.HesapServisBase
    {
        public override Task<HesapDurum> Ekle(HesapIstek istek, ServerCallContext context)
        {
            ServisHavuzu.VeritabaniServisi.HesapVT.Ekle(istek.Hesap);
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(istek.Hesap.Adres);
            var yanit = new HesapDurum();
            if (hesap == null) yanit.Durum = false;
            else
            {
                yanit.Durum = true;
                yanit.Hesap = hesap;
            }
            return Task.FromResult(yanit);
        }

        public override Task<HesapDurum> Guncelle(HesapIstek istek, ServerCallContext context)
        {
            ServisHavuzu.VeritabaniServisi.HesapVT.Guncelle(istek.Hesap);
            var yanit = new HesapDurum();
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(istek.Hesap.Adres);
            if (hesap == null) yanit.Durum = false;
            else
            {
                yanit.Durum = true;
                yanit.Hesap = hesap;
            }
            return Task.FromResult(yanit);
        }

        public override Task<HesapDurum> AdresIleGetir(HesapIstek istek, ServerCallContext context)
        {
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.AdresIleGetir(istek.Adres);
            var yanit = new HesapDurum();
            if (hesap == null) yanit.Durum = false;
            else
            {
                yanit.Durum = true;
                yanit.Hesap = hesap;
            }
            return Task.FromResult(yanit);
        }

        public override Task<HesapDurum> GenelAnahtarIleGetir(HesapIstek istek, ServerCallContext context)
        {
            var hesap = ServisHavuzu.VeritabaniServisi.HesapVT.GenelAnahtarIleGetir(istek.GenelAnahtar);
            var yanit = new HesapDurum();
            if (hesap == null) yanit.Durum = false;
            else
            {
                yanit.Durum = true;
                yanit.Hesap = hesap;
            }
            return Task.FromResult(yanit);
        }

        public override Task<HesapDurum> HepsiniGetir(Empty istek, ServerCallContext context)
        {
            var hesaplar = ServisHavuzu.VeritabaniServisi.HesapVT.HepsiniGetir();
            var yanit = new HesapDurum();
            if (hesaplar == null) yanit.Durum=false;
            else
            {
                yanit.Durum = true;
                yanit.Hesaplar.AddRange(hesaplar);
            }
            return Task.FromResult(yanit);
        }

        public override Task<HesapDurum> EnZenginNadetHesapGetir(HesapIstek istek, ServerCallContext context)
        {
            var hesaplar = ServisHavuzu.VeritabaniServisi.HesapVT.EnZenginNadetHesapGetir(istek.Adet);
            var yanit = new HesapDurum();
            if(hesaplar == null || hesaplar.Count < 1)
            {
                yanit.Durum = false;
                yanit.Mesaj = "Veritabanından n adet zengin hesp alınamadı";
            }
            else
            {
                yanit.Durum = true;
                yanit.Hesaplar.AddRange(hesaplar);
            }
            return Task.FromResult(yanit);
        }

    }
}
