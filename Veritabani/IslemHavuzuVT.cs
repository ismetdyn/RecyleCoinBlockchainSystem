using LiteDB;
using RecycleCoin.Grpc;

namespace RecycleCoinServer.Veritabani
{
    public class IslemHavuzuVT
    {
        private LiteDatabase _vt;

        public IslemHavuzuVT(LiteDatabase vt) => _vt = vt;

        /// <summary>
        /// işlem havuzuna ekle
        /// </summary>
        /// <param name="islem"></param>
        public void Ekle(Islem islem)
        {
            var islemler = HepsineEris();
            islemler.Insert(islem);
        }

        /// <summary>
        /// İşlem havuzundan belirtilen karma değerine sahip işlemi getir.
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
        /// İşlem havuzundan sayfalama ile işlem getir
        /// </summary>
        /// <param name="sayfaNumarasi"></param>
        /// <param name="sayfaBasinaSonuc"></param>
        /// <returns></returns>
        public IList<Islem> AdresIleListeGetir(string adres)
        {
            var islemler = HepsineEris();
            if (islemler is null || islemler.Count() < 1) return null;

            islemler.EnsureIndex(_ => _.ZamanDamgasi);
            var sorgu = islemler.Query()
                .OrderByDescending(_ => _.ZamanDamgasi)
                .Where(_ => _.Alici == adres || _.Gonderen == adres).ToList();
            return sorgu;
        }

        /// <summary>
        /// İşlem havuzundaki tüm işlemleri sil
        /// </summary>
        public void HepsiniSil()
        {
            var txns = HepsineEris();
            if (txns is null || txns.Count() < 1) return;

            txns.DeleteAll();
        }

        private ILiteCollection<Islem> HepsineEris()
        {
           return _vt.GetCollection<Islem>(Diger.Sabitler.TBL_ISLEM_HAVUZU);
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
