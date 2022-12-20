using LiteDB;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Veritabani
{
    /// <summary>
    /// Hesap Veritabanı, hesap eklemek, güncellemek ve silmek için.
    /// </summary>
    public class HesapVt
    {
        private readonly LiteDatabase _vt;
        public HesapVt(LiteDatabase vt) => _vt = vt;

        /// <summary>
        /// Yeni hesap ekle
        /// </summary>
        /// <param name="hesap"></param>
        public void Ekle(Hesap hesap)
        {
            if (hesap == null || hesap.Adres == null) return;
            var yeniHesap = new Hesap
            {
                Adres = hesap.Adres,
                Bakiye = 0,
                IslemAdedi = 0,
                Yaratildi = Hizmetler.ZamanGetir(),
                Guncellendi = Hizmetler.ZamanGetir(),
                GenelAnahtar = hesap.GenelAnahtar
            };
            var hesaplar = HepsiniEris();
            hesaplar.Insert(yeniHesap);
        }

        /// <summary>
        /// Hesap guncelle
        /// </summary>
        /// <param name="hesap"></param>
        public void Guncelle(Hesap hesap)
        {
            var hesaplar = HepsiniEris();
            hesaplar.Update(hesap);
        }

        /// <summary>
        /// Adres ile hesap getirme
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        public Hesap AdresIleGetir(string adres)
        {
            var hesaplar = HepsiniEris();
            if(hesaplar is null) return null;

            hesaplar.EnsureIndex(_ => _.Adres);
            return hesaplar.FindOne(_ => _.Adres == adres);
        }

        /// <summary>
        /// Genl anahtar ile hesap getirme
        /// </summary>
        /// <param name="genelAnahtar"></param>
        /// <returns></returns>
        public Hesap GenelAnahtarIleGetir(string genelAnahtar)
        {
            var hesaplar = HepsiniEris();
            hesaplar.EnsureIndex(_ => _.GenelAnahtar);
            var hesap = hesaplar.FindOne(_ => _.GenelAnahtar == genelAnahtar);
            return hesap;
        }

        /// <summary>
        /// Tüm hesapları getir
        /// </summary>
        /// <returns></returns>
        private ILiteCollection<Hesap> HepsiniEris()
        {
           return  _vt.GetCollection<Hesap>(Sabitler.TBL_HESAPLAR);
        }

        public List<Hesap> HepsiniGetir()
        {
            var koleksiyon = HepsiniEris();
            var hesaplar = koleksiyon.FindAll().ToList();
            return hesaplar;
        }

        public List<Hesap> EnZenginNadetHesapGetir(int n)
        {
            if (n == -1) return HepsiniGetir();
            else
            {
                var hesaplar = HepsiniEris();
                hesaplar.EnsureIndex(_ => _.Bakiye);
                var sorgu = hesaplar.Query()
                    .OrderByDescending(_ => _.Bakiye)
                    .Limit(n).ToList();
                return sorgu;
            }
        }
    }
}
