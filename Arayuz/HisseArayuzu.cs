using RecycleCoin.Grpc;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Arayuz
{
    public class HisseArayuzu
    {
        public HisseArayuzu() =>
            Console.WriteLine(".... Hisse başlatıldı");

        public Hisse EnbuyukHisseGetir() =>
            ServisHavuzu.VeritabaniServisi.HisseVT.EnBuyukGetir();

        public void EkleGuncelle(Hisse hisse) => 
            ServisHavuzu.VeritabaniServisi.HisseVT.EkleGuncelle(hisse);
    }
}
