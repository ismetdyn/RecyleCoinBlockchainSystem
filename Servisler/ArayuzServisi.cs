using RecycleCoinServer.Arayuz;

namespace RecycleCoinServer.Servisler
{
    public class ArayuzServisi
    {
        public EsArayuzu Es { get; set; }
        public HesapArayuzu Hesap { get; set; }
        public BlokArayuzu Blok { get; set; }
        public IslemArayuzu Islem { get; set; }
        public IslemHavuzuArayuzu IslemHavuzu { get; set; }
        public HisseArayuzu Hisse { get; set; }

        public void Baslat()
        {
            Console.WriteLine("..... Facade servis başlatılıyor.");
            Es = new EsArayuzu();
            Hisse = new HisseArayuzu();
            Hesap = new HesapArayuzu();
            IslemHavuzu = new IslemHavuzuArayuzu();
            Islem = new IslemArayuzu();
            Blok = new BlokArayuzu();
            Console.WriteLine(".......Facade servis hazır");
        }
    }
}
