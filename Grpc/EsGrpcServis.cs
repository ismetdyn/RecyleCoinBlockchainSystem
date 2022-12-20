using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RecycleCoin.Grpc;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Grpc
{
    public class EsGrpcServis : EsServis.EsServisBase
    {
        public override Task<EsDurum> Ekle(EsIstek istek, ServerCallContext context)
        {
            ServisHavuzu.VeritabaniServisi.EsVT.EkleGuncelle(istek.Es);
            var yanit = new EsDurum();
            return Task.FromResult(yanit);
        }

        public override Task<EsDurum> DugumDurumuGetir(EsIstek istek, ServerCallContext context)
        {
            ServisHavuzu.ArayuzServisi.Es.Ekle(new Es
            {
                Adres = istek.DugumIpAdresi,
                OnyukluMu = false,
                ErisilebilirMi = true,
                SonErisim = Diger.Hizmetler.ZamanGetir(),
                ZamanDamgasi = Diger.Hizmetler.ZamanGetir()
            });

            var dugumDurum = ServisHavuzu.ArayuzServisi.Es.DugumDurumuGetir();
            return Task.FromResult(dugumDurum);
        }

        public override Task<EsDurum> HepsiniGetir(Empty request, ServerCallContext context)
        {
            var esler = ServisHavuzu.VeritabaniServisi.EsVT.HepsiniGetir();
            var yanit = new EsDurum();
            if (esler == null) yanit.Durum = false;
            else
            {
                yanit.Durum = true;
                yanit.Esler.AddRange(esler);
            }
            return Task.FromResult(yanit);
        }
    }
}
