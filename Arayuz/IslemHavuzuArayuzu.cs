using RecycleCoin.Grpc;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Arayuz
{
    public class IslemHavuzuArayuzu
    {
        public IslemHavuzuArayuzu() =>
            Console.WriteLine(".... İşlem Havuzu başlatıldı");

        public bool IslemHavuzdaVarMi(Islem islem)
        {
            var sonuc =
                ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.KarmaIleGetir(islem.Karma);
            if(sonuc is null) return false;

            return true;
        }
    }
}
