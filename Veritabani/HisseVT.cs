using LiteDB;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;

namespace RecycleCoinServer.Veritabani
{
	/// <summary>
	/// Hisse veritabanı
	/// </summary>
	public class HisseVT
	{
		private readonly LiteDatabase _vt;

		public HisseVT(LiteDatabase vt) => _vt = vt;

		/// <summary>
		/// Hisse ekle, güncelle
		/// </summary>
		/// <param name="hisse"></param>
		public void EkleGuncelle(Hisse hisse)
		{
			var varolanHisse = AdresIleGetir(hisse.Adres);
			if (varolanHisse is null) HepsineEris().Insert(hisse);
		}

		/// <summary>
		/// Tüm hisseleri sil
		/// </summary>
		public void HepsiniSil()
		{
			var hisseler = HepsineEris();
			if (hisseler is null || hisseler.Count() < 1) return;

			hisseler.DeleteAll();
		}

		/// <summary>
		/// Miktar bazında maksimum bahis alın
		/// </summary>
		/// <returns></returns>
		public Hisse EnBuyukGetir()
		{
			var hisses = HepsineEris();
			if (hisses is null || hisses.Count() < 1) return null;

			hisses.EnsureIndex(_ => _.Tutar);
			var sorgu = hisses.Query()
				.OrderByDescending(_ => _.Tutar);
			return sorgu.FirstOrDefault();
		}


		/// <summary>
		/// Adrese göre hisse getir
		/// </summary>
		/// <param name="adres"></param>
		/// <returns></returns>
		private Hisse AdresIleGetir(object adres)
		{
			var hisseler = HepsineEris();
			if (hisseler is null) return null;

			hisseler.EnsureIndex(_ => _.Adres);

			return hisseler.FindOne(_ => _.Adres == adres);
		}

		/// <summary>
		/// Tüm hissleri getir
		/// </summary>
		/// <returns></returns>
		private ILiteCollection<Hisse> HepsineEris()
		{
			var hisseler = this._vt.GetCollection<Hisse>(Sabitler.TBL_HISSELER);
			hisseler.EnsureIndex(_ => _.Tutar);
			return hisseler;
		}

		public List<Hisse> HepsiniGetir()
		{
			var kolekiyon = HepsineEris();
			var hisseler = kolekiyon.FindAll().ToList();
			return hisseler;
		}

	}
}
