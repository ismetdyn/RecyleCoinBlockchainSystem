using LiteDB;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;

namespace RecycleCoinServer.Veritabani
{
    public class BlokVT
    {
        private LiteDatabase _vt;
        public BlokVT(LiteDatabase vt) => _vt = vt;

        /// <summary>
        /// Blok ekle
        /// </summary>
        /// <param name="blok"></param>
        /// <returns></returns>
        public BlokDurum Ekle (Blok blok)
        {
            var bloklar = HepsiniEris();
            try
            {
                bloklar.Insert(blok);
                return new BlokDurum
                {
                    Durum = true,
                    Mesaj = "blok başarıyla eklendi"
                };
            }
            catch
            {
                return new BlokDurum
                {
                    Durum = false,
                    Mesaj = " "
                };
            }
        }

        /// <summary>
        /// Blok Yüksekliğine göre sıralanmış İlk Bloğu veya Genesis bloğunu getir
        /// </summary>
        /// <returns></returns>
        public Blok BasGetir()
        {
            var blok = HepsiniEris().FindAll().FirstOrDefault();
            return blok;
        }


        /// <summary>
        /// Blok Yüksekliğine göre sıralanan Son bloğu getir
        /// </summary>
        /// <returns></returns>
        public Blok SonGetir()
        {
            var blok = HepsiniEris().FindOne(Query.All(Query.Descending));
            return blok;
        }

        /// <summary>
        /// Blok yüksekliğine göre blok getir
        /// </summary>
        /// <param name="yukseklik"></param>
        /// <returns></returns>
        public Blok YukseklikIleGetir(long yukseklik)
        {
            var coll = HepsiniEris();
            var blok = coll.Query().Where(_ => _.Yukseklik == yukseklik).ToEnumerable();
            if (blok.Any()) return blok.FirstOrDefault();

            return null;
        }

        /// <summary>
        /// Karma değeri ile blok getir
        /// </summary>
        /// <param name="karma"></param>
        /// <returns></returns>
        public Blok KarmaIleGetir(string karma)
        {
            var coll = HepsiniEris();
            var blok = coll.Query().Where(_ => _.Karma == karma).ToEnumerable();
            if(blok.Any()) return blok.FirstOrDefault();
            
            return null;
        }

        /// <summary>
        /// Belirli yükseklikten başlayarak 50 satıra kadar bloklar alın
        /// </summary>
        /// <param name="tabanYukseklik"></param>
        /// <returns></returns>
        public List<Blok> TabanYukseklikIleGetir(long tabanYukseklik)
        {
            var bloklar = HepsiniEris();
            bloklar.EnsureIndex(_ => _.Yukseklik);
            var sorgu = bloklar.Query()
                .OrderByDescending(_ => _.Yukseklik)
                .Where(_ => _.Yukseklik > tabanYukseklik && _.Yukseklik <= tabanYukseklik + 50)
                .ToList();
            return sorgu;
        }

        /// <summary>
        /// Adrese/doğrulayıcıya göre doğrulanan blokları sayfa olarak alın
        /// </summary>
        /// <param name="dogrulayici"></param>
        /// <returns></returns>
        public List<Blok> DogrulayiciIleGetir(
            string dogrulayici)
        {
            var coll = HepsiniEris();
            coll.EnsureIndex(_ => _.Dogrulayici);
            var sorgu = coll.Query()
                .OrderByDescending(_ => _.Yukseklik)
                .Where(_ => _.Dogrulayici == dogrulayici)
                .ToList();
            return sorgu;
        }

        public List<string> KarmaListesiniGetir()
        {
            var bloklar = HepsiniGetir();
            List<string> karmaListesi = new List<string>();
            foreach (var blok in bloklar)
            {
                var karma = blok.Karma;
                karmaListesi.Append(karma);
            }
            return karmaListesi;
        }

        /// <summary>
        /// Tüm blokları getir
        /// </summary>
        /// <returns></returns>
        private ILiteCollection<Blok> HepsiniEris()
        {
            var coll = _vt.GetCollection<Blok>(Sabitler.TBL_BLOKLAR);
            coll.EnsureIndex(_ => _.Yukseklik);
            return coll;
        }

        /// <summary>
        /// Tüm blok karmalarını getir
        /// </summary>
        /// <returns></returns>
        public List<Blok> HepsiniGetir()
        {
            var koleksiyon = HepsiniEris();
            var bloklar = koleksiyon.FindAll().ToList();
            return bloklar;
        }

        public List<Blok> SonNAdetGetir(int n)
        {
            if (n == -1) return HepsiniGetir();
            else
            {
                var bloklar = HepsiniEris();
                bloklar.EnsureIndex(_ => _.Yukseklik);
                var sorgu = bloklar.Query()
                        .OrderByDescending(_ => _.Yukseklik)
                        .Limit(n).ToList();
                return sorgu;
            }
        }
    }
}
