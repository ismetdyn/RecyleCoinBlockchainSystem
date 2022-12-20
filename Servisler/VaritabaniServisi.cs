using LiteDB;
using RecycleCoinServer.Veritabani;

namespace RecycleCoinServer.Servisler
{
   /**
    * İşlem, blok vs. için veritabanı boyutunu en aza indirmek için 
    * birden fazla veritabanı kullanıyorum. 
    * Boyut her veritabanı için daha küçük olacaktır.
    **/
    public class VaritabaniServisi
    {
        private readonly LiteDatabase VT_BLOK;
        private readonly LiteDatabase VT_HESAP;
        private readonly LiteDatabase VT_ISLEM;
        private readonly LiteDatabase VT_ISLEM_HAVUZU;
        private readonly LiteDatabase VT_ES;
        private readonly LiteDatabase VT_HISSE;

        public BlokVT BlokVT { get; set; }
        public IslemVT IslemVT { get; set; }
        public EsVT EsVT { get; set; }
        public HesapVt HesapVT { get; set; }
        public IslemHavuzuVT IslemHavuzuVT { get; set; }
        public HisseVT HisseVT { get; set; }

        private LiteDatabase Ilklendir(string yol) =>
            new LiteDatabase(yol);

        public VaritabaniServisi()
        {
            // vt klasörü oluştur
            if(!Directory.Exists(@"VtDosyalari"))
                Directory.CreateDirectory(@"VtDosyalari");

            VT_BLOK = Ilklendir(@"VtDosyalari//blok.vt");
            VT_HESAP = Ilklendir(@"VtDosyalari//hesap.vt");
            VT_ISLEM = Ilklendir(@"VtDosyalari//islem.vt");
            VT_ISLEM_HAVUZU = Ilklendir(@"VtDosyalari//islem_havuzu.vt");
            VT_HISSE = Ilklendir(@"VtDosyalari//hisse.vt");
            VT_ES = Ilklendir(@"VtDosyalari//es.vt");
        }


        public void Baslat()
        {
            Console.WriteLine("..... Veritabanı servisi başlatılıyor");
            BlokVT = new BlokVT(VT_BLOK);
            HesapVT = new HesapVt(VT_HESAP);
            IslemVT = new IslemVT(VT_ISLEM);
            IslemHavuzuVT = new IslemHavuzuVT(this.VT_ISLEM_HAVUZU);
            HisseVT = new HisseVT(this.VT_HISSE);
            EsVT = new EsVT(this.VT_ES);
            Console.WriteLine(".... Veritabanı servisi hazır");
        }

        public void Durdur()
        {
            Console.WriteLine("...Veritabanı servisi kapatılıyor");
            VT_BLOK.Dispose();
            VT_HISSE.Dispose();
            VT_ISLEM.Dispose();
            VT_ISLEM_HAVUZU.Dispose();
            VT_ES.Dispose();
            VT_HESAP.Dispose();
            Console.WriteLine("Veritabanı durduruldu.");
        }
    }
}
