using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Newtonsoft.Json;
using RecycleCoin.Grpc;
using RecycleCoinServer.Diger;
using RecycleCoinServer.Servisler;

namespace RecycleCoinServer.Grpc
{
    public class BlokGrpcServis : BlokServis.BlokServisBase
    {
        public override Task<BlokDurum> Ekle(BlokIstek istek, ServerCallContext context)
        {
            var sonBlok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();

            // blok karmasını doğrula
            if (istek.Blok.OncekiKarma != sonBlok.Karma)
            {
                return Task.FromResult(new BlokDurum
                {
                    Durum = false,
                    Mesaj = "Karma geçersiz"
                });
            }

            // blok yüksekliğini doğrula
            if (istek.Blok.Yukseklik != sonBlok.Yukseklik + 1)
            {
                return Task.FromResult(new BlokDurum
                {
                    Durum = false,
                    Mesaj = "Geçersiz yükseklik"
                });
            }

            var ekleDurum = ServisHavuzu.VeritabaniServisi.BlokVT.Ekle(istek.Blok);

            // işlemleri aç
            var islemler = JsonConvert.DeserializeObject<List<Islem>>(istek.Blok.Islemler);

            // bakiyeleri güncelle
            ServisHavuzu.ArayuzServisi.Hesap.BakiyeGuncelle(islemler);

            // havuzu işlemler vt'sine taşı
            ServisHavuzu.ArayuzServisi.Islem.TopluEkle(islemler);

            // havuzu temizle
            ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.HepsiniSil();

            return Task.FromResult(ekleDurum);
        }

        public override Task<BlokDurum> KarmaIleTekilGetir(BlokIstek istek, ServerCallContext context)
        {
            var blok = ServisHavuzu.VeritabaniServisi.BlokVT.KarmaIleGetir(istek.Karma);
			var yanit = new BlokDurum();
			if (blok == null)
			{
				yanit.Durum = false;
				yanit.Mesaj = "Veritabanından blok getirilemedi";
			}
			else
			{
				yanit.Durum = true;
				yanit.Blok = blok;
			}
		    return Task.FromResult(yanit);
		}

        public override Task<BlokDurum> YukseklikIleTekilGetir(BlokIstek istek, ServerCallContext context)
        {
            var blok = ServisHavuzu.VeritabaniServisi.BlokVT.YukseklikIleGetir(istek.Yukseklik);
			var yanit = new BlokDurum();
			if (blok == null)
			{
				yanit.Durum = false;
				yanit.Mesaj = "Veritabanından blok getirilemedi";
			}
			else
			{
				yanit.Durum = true;
				yanit.Blok = blok;
			}
			return Task.FromResult(yanit);
		}

        public override Task<BlokDurum> TabanYukseklikIleListeGetir(BlokIstek istek, ServerCallContext context)
        {
            var bloklar = ServisHavuzu.VeritabaniServisi.BlokVT.TabanYukseklikIleGetir(istek.Yukseklik);
            var yanit = new BlokDurum();
            if(bloklar == null || bloklar.Count < 1)
            {
                yanit.Durum = false;
                yanit.Mesaj = "Bloklar bulunamadi";
            }
            else
            {
                yanit.Durum = true;
                yanit.Bloklar.AddRange(bloklar);
            }
			return Task.FromResult(yanit);
		}

        public override Task<BlokDurum> BasGetir(Empty request, ServerCallContext context)
        {
            var blok = ServisHavuzu.VeritabaniServisi.BlokVT.BasGetir();
            var yanit = new BlokDurum();
            if (blok == null)
            {
                yanit.Durum = false;
                yanit.Mesaj = "Veritabanından blok getirilemedi";
            }
            else
            {
                yanit.Durum = true;
                yanit.Blok= blok;
			}
			return Task.FromResult(yanit);
		}

        public override Task<BlokDurum> SonGetir(Empty request, ServerCallContext context)
        {
            var blok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
			var yanit = new BlokDurum();
			if (blok == null)
			{
				yanit.Durum = false;
				yanit.Mesaj = "Veritabanından blok getirilemedi";
			}
			else
			{
				yanit.Durum = true;
				yanit.Blok = blok;
			}
			return Task.FromResult(yanit);
		}

        public override Task<BlokDurum> SonNadetBlokGetir(BlokIstek istek, ServerCallContext context)
        {
            var bloklar = ServisHavuzu.VeritabaniServisi.BlokVT.SonNAdetGetir(istek.Adet);
            var yanit = new BlokDurum();
            if(bloklar == null || bloklar.Count < 1)
            {
                yanit.Durum = false;
                yanit.Mesaj = "Veritabanından N adet blok alınamadı";
            }
            else
            {
                yanit.Durum = true;
                yanit.Bloklar.AddRange(bloklar);
            }
            return Task.FromResult(yanit);
        }

        public override Task<BlokDurum> DogrulayiciIleListeGetir(BlokIstek istek, ServerCallContext context)
        {
            var bloklar = ServisHavuzu.VeritabaniServisi.BlokVT.DogrulayiciIleGetir(istek.Dogrulayici);
            var yanit = new BlokDurum();
            if (bloklar == null || bloklar.Count < 1)
            {
                yanit.Durum = false;
                yanit.Mesaj = "Bloklar bulunamadi";
            }
            else
            {
                yanit.Durum = true;
                yanit.Bloklar.AddRange(bloklar);
            }
            return Task.FromResult(yanit);
        }
    }
}
