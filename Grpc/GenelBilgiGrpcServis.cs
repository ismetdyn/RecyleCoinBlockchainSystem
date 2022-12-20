using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RecycleCoin.Grpc;
using RecycleCoinServer.Servisler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoinServer.Grpc
{
    public class GenelBilgiGrpcServis : GenelBilgi.GenelBilgiBase
    {
        public override Task<Bilgi> AgGenelBilgisiGetir(Empty request, ServerCallContext context)
        {
            var yanit = new Bilgi { Durum = true };
            
            var blok = ServisHavuzu.VeritabaniServisi.BlokVT.SonGetir();
            if (blok == null) yanit.Durum = false;
            else yanit.SonBlokYuksekligi = blok.Yukseklik;
            
            var islemler = ServisHavuzu.VeritabaniServisi.IslemVT.HepsiniGetir();
            if (islemler == null || islemler.Count < 1) yanit.Durum = false;
            else
            {
                yanit.IslemSayisi = islemler.Count;
                double toplam = 0;
                foreach (var i in islemler) { toplam += i.Tutar; }
                yanit.ToplamIslemTutari= toplam;
            }
            
            var havuzdakiIslemler = ServisHavuzu.VeritabaniServisi.IslemHavuzuVT.HepsiniGetir();
            if(havuzdakiIslemler == null) yanit.Durum=false;
            else
            {
                yanit.HavuzdakiIslemSayisi = havuzdakiIslemler.Count;
                double toplam2 = 0;
                foreach (var i in havuzdakiIslemler) { toplam2 += i.Tutar; }
                yanit.HavuzdakiToplamIslemTutari = toplam2;
            }

            var hesaplar = ServisHavuzu.VeritabaniServisi.HesapVT.HepsiniGetir();
            if(hesaplar == null || hesaplar.Count < 1) yanit.Durum= false;
            else
            {
                yanit.ToplamHesapSayisi = hesaplar.Count;
                double toplam3 = 0;
                foreach (var h in hesaplar) { toplam3 += h.Bakiye;}
                yanit.HesaplardakiToplamPara = toplam3;
            }

            return Task.FromResult(yanit);
        }
    }
}
