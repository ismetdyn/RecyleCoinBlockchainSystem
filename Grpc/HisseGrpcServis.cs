using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RecycleCoin.Grpc;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Grpc
{
    public class HisseGrpcServis : HisseServis.HisseServisBase
    {
        
        public override Task<HisseDurum> Ekle(HisseIstek istek, ServerCallContext context)
        {
            ServisHavuzu.VeritabaniServisi.HisseVT.EkleGuncelle(istek.Hisse);
            return Task.FromResult(new HisseDurum
            {
                Mesaj = "true"
            });
        }

        public override Task<HisseDurum> HepsiniGetir(Empty istek, ServerCallContext context)
        {
            var hisseler = ServisHavuzu.VeritabaniServisi.HisseVT.HepsiniGetir();
            var yanit = new HisseDurum();
            if (hisseler == null || hisseler.Count < 1) yanit.Durum = false;
            else
            {
                yanit.Durum = true;
                yanit.Hisseler.AddRange(hisseler);
            }
            return Task.FromResult(yanit);
        }
    }
}
