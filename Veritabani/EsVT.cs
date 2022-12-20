using LiteDB;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;

namespace RecycleCoinServer.Veritabani
{
    /// <summary>
    /// Eş veritabanı, eşlerin listesine eklemek, güncellemek için
    /// </summary>
    public class EsVT
    {
        private readonly LiteDatabase _vt;

        public EsVT(LiteDatabase vt) => _vt = vt;

        /// <summary>
        /// Eş ekle
        /// </summary>
        /// <param name="es"></param>
        public void EkleGuncelle(Es es)
        {
            var varolanEsler = AdresIleGetir(es.Adres);
            if (varolanEsler is null) HepsineEris().Upsert(es);
        }

        /// <summary>
        /// Tüm eşleri getir
        /// </summary>
        /// <returns></returns>
        private ILiteCollection<Es> HepsineEris()
        {
            var ess = this._vt.GetCollection<Es>(Sabitler.TBL_ESLER);
            ess.EnsureIndex(_ => _.SonErisim);
            return ess;
        }

        public List<Es> HepsiniGetir()
        {
            var koleksiyon = HepsineEris();
            var esler = koleksiyon.FindAll().ToList();
            return esler;
        }

        /// <summary>
        /// Ağ adresi/IP ile eş alın
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns
        private Es AdresIleGetir(string adres)
        {
            var esler = HepsineEris();
            if (esler is null) return null;

            esler.EnsureIndex(_ => _.Adres);
            var es = esler.FindOne(_ => _.Adres == adres);
            return es;
        }
    }
}
