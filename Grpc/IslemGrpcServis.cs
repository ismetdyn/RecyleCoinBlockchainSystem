using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using NBitcoin;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Grpc
{
	public class IslemGrpcServis : IslemServis.IslemServisBase
	{

		public override Task<IslemDurum> KarmaIleTekilGetir(IslemIstek istek, ServerCallContext context)
		{
			var islem = ServisHavuzu.VeritabaniServisi.IslemVT.KarmaIleGetir(istek.Karma);
			var islemDurumu = new IslemDurum();
			if (islem == null) islemDurumu.Durum = false;
			else
			{
				islemDurumu.Durum = true;
				islemDurumu.Islem = islem;
			}
			return Task.FromResult(islemDurumu);
		}

		private bool ImzaDogrula(Islem islem)
		{
			var genelAnahtar = new PubKey(islem.GenelAnahtar);
			return genelAnahtar.VerifyMessage(islem.Karma, islem.Imza);
		}

		public override Task<IslemDurum> Al(IslemIstek istek, ServerCallContext context)
		{
			Console.WriteLine("-- Gelen İslem:\nkarma: {0}, tutar {1}",
				istek.Islem.Karma, istek.Islem.Tutar);

			var islemKarmasi = Diger.Hizmetler.IslemKarmasiOlustur(istek.Islem);
			if (!islemKarmasi.Equals(istek.Islem.Karma))
			{
				return Task.FromResult(new IslemDurum
				{
					Durum = false,
					Mesaj = "Geçersiz islem karması"
				});
			}

			var imzaGecerlimi = ImzaDogrula(istek.Islem);
			if (!imzaGecerlimi)
			{
				return Task.FromResult(new IslemDurum
				{
					Durum = false,
					Mesaj = "Geçersiz imza"
				});
			}

			ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.Ekle(istek.Islem);
			return Task.FromResult(new IslemDurum
			{
				Durum = true,
				Mesaj = "İslem başarıla alındı!"
			});
		}

		public override Task<IslemDurum> Aktar(IslemIstek istek, ServerCallContext context)
		{
			Hizmetler.IslemYazdir(istek.Islem);

			// Karma doğrula
			var hesaplananKarma = Diger.Hizmetler.IslemKarmasiOlustur(istek.Islem);
			if (!hesaplananKarma.Equals(istek.Islem.Karma))
			{
				return Task.FromResult(new IslemDurum
				{
					Durum = false,
					Mesaj = "Geçersiz işlem karması"
				});
			}

			Console.WriteLine("=== Hesaplanan Karma: {0}", hesaplananKarma);

			// imza dogrula
			var imzaGecerlimi = ImzaDogrula(istek.Islem);
			if (!imzaGecerlimi)
			{
				return Task.FromResult(new IslemDurum
				{
					Durum = false,
					Mesaj = "Geçersiz imza"
				});
			}

			// İşlemin havuzda olup olmadığını kontrol et
			var havuzdakiIslem = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.KarmaIleGetir(
				istek.Islem.Karma);
			if (havuzdakiIslem is not null)
			{
				return Task.FromResult(new IslemDurum
				{
					Durum = false,
					Mesaj = "Çift işlem (aynı işlem havuzda var)"
				});
			}

			ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.Ekle(istek.Islem);

			// işlemi kendim dahil tüm eşlere yayınla.
			Task.Run(() => ServisHavuzu.EstenEseServis.IslemYayinla(istek.Islem));

			Console.WriteLine("\nIslem Veritabanına eklend ve eslere duyuruldu!");

			// başarılı işlem yanıtı
			return Task.FromResult(new IslemDurum
			{
				Durum = true,
				Mesaj = "İşlem tamamlandı"
			});
		}

		public override Task<IslemDurum> ExplorerdanAl(IslemIstek istek, ServerCallContext context)
		{
			var islem = istek.Islem;
			var yanit = new IslemDurum { Durum = true };
			if (islem != null)
			{
				islem = ServisHavuzu.ArayuzServisi.Islem.ExplorerIslemOlustur(islem);
				Hizmetler.IslemYazdir(islem);

				// Karma doğrula
				var hesaplananKarma = Diger.Hizmetler.IslemKarmasiOlustur(istek.Islem);
				if (!hesaplananKarma.Equals(istek.Islem.Karma))
				{
					yanit.Durum = false;
					yanit.Mesaj = "Geçersiz işlem karması";
					return Task.FromResult(yanit);
				}

				Console.WriteLine("=== Hesaplanan Karma: {0}", hesaplananKarma);

				// imza dogrula
				var imzaGecerlimi = ImzaDogrula(istek.Islem);
				if (!imzaGecerlimi)
				{
					yanit.Durum = false;
					yanit.Mesaj = "Geçersiz imza";
					return Task.FromResult(yanit);
				}

				// İşlemin havuzda olup olmadığını kontrol et
				var havuzdakiIslem = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.KarmaIleGetir(
					istek.Islem.Karma);
				if (havuzdakiIslem is not null)
				{
					yanit.Durum = false;
					yanit.Mesaj = "Çift işlem (aynı işlem havuzda var)";
					return Task.FromResult(yanit);
				}

				ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.Ekle(istek.Islem);

				// işlemi kendim dahil tüm eşlere yayınla.
				Task.Run(() => ServisHavuzu.EstenEseServis.IslemYayinla(istek.Islem));

				Console.WriteLine("\nIslem Veritabanına eklend ve eslere duyuruldu!");
			}

			return Task.FromResult(yanit);
		}

		public override Task<IslemDurum> AdresIleListeGetir(IslemIstek istek, ServerCallContext context)
		{
			var islemler = ServisHavuzu.VeritabaniServisi.IslemVT.AdresIleGetir(istek.Adres);
			var islemDurum = new IslemDurum();
			if (islemler == null || islemler.Count < 1) islemDurum.Durum = false;
			else
			{
				islemDurum.Durum = true;
				islemDurum.Islemler.AddRange(islemler);
			}
			return Task.FromResult(islemDurum);
		}

		public override Task<IslemDurum> GecmisTumIslemleriGetir(Empty istek, ServerCallContext context)
		{
			var islemler = ServisHavuzu.VeritabaniServisi.IslemVT.HepsiniGetir();
			var islemDurum = new IslemDurum();
			if (islemler == null || islemler.Count < 1) islemDurum.Durum = false;
			else
			{
				islemDurum.Durum = true;
				islemDurum.Islemler.AddRange(islemler);
			}
			return Task.FromResult(islemDurum);
		}

		public override Task<IslemDurum> HavuzdanAdresIleListeGetir(IslemIstek istek, ServerCallContext context)
		{
			var islemler = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.AdresIleListeGetir(istek.Adres);
			var islemDurum = new IslemDurum();
			if (islemler == null || islemler.Count < 1) islemDurum.Durum = false;
			else
			{
				islemDurum.Durum = true;
				islemDurum.Islemler.AddRange(islemler);
			}
			return Task.FromResult(islemDurum);
		}

		public override Task<IslemDurum> HavuzdanKarmaIleTekilGetir(IslemIstek istek, ServerCallContext context)
		{
			var islem = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.KarmaIleGetir(istek.Karma);
			var islemDurum = new IslemDurum();
			if (islem == null) islemDurum.Durum = false;
			else
			{
				islemDurum.Durum = true;
				islemDurum.Islem = islem;
			}
			return Task.FromResult(islemDurum);
		}

		public override Task<IslemDurum> HavuzuGetir(Empty istek, ServerCallContext context)
		{
			var islemler = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.HepsiniGetir();
			var islemDurum = new IslemDurum();
			if (islemler == null || islemler.Count < 1) islemDurum.Durum = false;
			else
			{
				islemDurum.Durum = true;
				islemDurum.Islemler.AddRange(islemler);
			}
			return Task.FromResult(islemDurum);
		}

		public override Task<IslemDurum> SonNadetIslemGetir(IslemIstek istek, ServerCallContext context)
		{
			var hesaplar = ServisHavuzu.VeritabaniServisi.IslemVT.SonNadetIslemGetir(istek.Adet);
			var yanit = new IslemDurum();
			if (hesaplar == null || hesaplar.Count < 1)
			{
				yanit.Durum = false;
				yanit.Mesaj = "Veritabanından N adet blok alınamadı";
			}
			else
			{
				yanit.Durum = true;
				yanit.Islemler.AddRange(hesaplar);
			}
			return Task.FromResult(yanit);
		}

		public override Task<IslemDurum> HavuzdanSonNadetIslemGetir(IslemIstek istek, ServerCallContext context)
		{
			var hesaplar = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.SonNadetIslemGetir(istek.Adet);
			var yanit = new IslemDurum();
			if (hesaplar == null || hesaplar.Count < 1)
			{
				yanit.Durum = false;
				yanit.Mesaj = "Veritabanından N adet blok alınamadı";
			}
			else
			{
				yanit.Durum = true;
				yanit.Islemler.AddRange(hesaplar);
			}
			return Task.FromResult(yanit);
		}

		public override Task<IslemDurum> YukseklikIleIslemListeGetir(IslemIstek istek, ServerCallContext context)
		{
			var islemler = ServisHavuzu.VeritabaniServisi.IslemVT.YukseklikIleListeGetir(istek.Yukseklik);
			var islemDurum = new IslemDurum();
			if (islemler == null || islemler.Count < 1) islemDurum.Durum = false;
			else
			{
				islemDurum.Durum = true;
				islemDurum.Islemler.AddRange(islemler);
			}
			return Task.FromResult(islemDurum);

		}
	}
}
