using LiteDB;
using RecycleCoinServer.Diger;
using RecycleCoin.Grpc;

namespace RecycleCoinServer.Veritabani
{
    /// <summary>
    /// İşlem DB, ekleme, güncelleme işlemi için
    /// </summary>
    public class IslemVT
    {
        private readonly LiteDatabase _vt;

        public IslemVT(LiteDatabase vt) => _vt = vt;

        /// <summary>
        /// Aynı anda toplu işlem ekle
        /// </summary>
        /// <param name="islemler"></param>
        /// <returns></returns>
        public bool TopluEkle(List<Islem> islemler)
        {
            try
            {
                var coll = HepsineEris();
                coll.InsertBulk(islemler);
                return true;
            }
            catch { return false; }
        }


        /// <summary>
        /// Bir işlem ekle
        /// </summary>
        /// <param name="islem"></param>
        /// <returns></returns>
        public bool Ekle(Islem islem)
        {
            try
            {
                var islemler = HepsineEris();
                islemler.Insert(islem);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Adrese ait tüm işlemleri sayfalama ile getir
        /// </summary>
        /// <param name="adres"></param>
        /// <param name="sayfaNumarasi"></param>
        /// <param name="sayfaBasinaSonuc"></param>
        /// <returns></returns>
        public IList<Islem> AdresIleGetir(string adres)
        {
            var txns = HepsineEris();
            if (txns is null || txns.Count() < 1) return null;

            txns.EnsureIndex(_ => _.Gonderen);
            txns.EnsureIndex(_ => _.Alici);
            var sorgu = txns.Query()
                .OrderByDescending(_ => _.ZamanDamgasi)
                .Where(_ => _.Gonderen == adres || _.Alici == adres).ToList();
            return sorgu;
        }

        public IList<Islem> YukseklikIleListeGetir(long yukseklik)
        {
            var islemler = HepsineEris();
            if (islemler is null || islemler.Count() < 1) return null;

            islemler.EnsureIndex(_ => _.Yukseklik);
            var sorgu = islemler.Query()
                .OrderByDescending(_=> _.ZamanDamgasi)
                .Where(_ => _.Yukseklik == yukseklik)
                .ToList();
            return sorgu;
        }

        /// <summary>
        /// Karma ile işlem getir
        /// </summary>
        /// <param name="karma"></param>
        /// <returns></returns>
        public Islem KarmaIleGetir(string karma)
        {
            var islemler = HepsineEris();
            if (islemler is null || islemler.Count() < 1) return null;

            islemler.EnsureIndex(_ => _.Karma);
            var islem = islemler.FindOne(_ => _.Karma == karma);
            return islem;
        }

        /// <summary>
        /// Tüm işlemleri getir
        /// </summary>
        /// <returns></returns>
        private ILiteCollection<Islem> HepsineEris()
        {
           return _vt.GetCollection<Islem>(Sabitler.TBL_ISLEMLER);
        }

        public List<Islem> HepsiniGetir()
        {
            var koleksiyon = HepsineEris();
            var islemler = koleksiyon.FindAll().ToList();
            return islemler;
        }

        public List<Islem> SonNadetIslemGetir(int n)
        {
            if (n == -1) return HepsiniGetir();
            else
            {
                var islemler = HepsineEris();
                islemler.EnsureIndex(_ => _.ZamanDamgasi);
                var sorgu = islemler.Query()
                        .OrderByDescending(_ => _.ZamanDamgasi)
                        .Limit(n).ToList();
                return sorgu;
            }
        }
    }
}
