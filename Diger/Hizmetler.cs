using RecycleCoin.Grpc;
using System.Security.Cryptography;
using System.Text;

namespace RecycleCoinServer.Diger
{
    public static class Hizmetler
    {
        public static string KarmaUret(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return BytesToHex(hash);
        }

        public static byte[] KarmaBytelariUret(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return hash;
        }

        public static string KarmaHexUret(string hex)
        {
            byte[] bytes = HexToBytes(hex);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return BytesToHex(hash);
        }

        public static string BytesToHex(byte[] bytes)
        {
            return Convert.ToHexString(bytes).ToLower();
        }

        public static byte[] HexToBytes(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        public static DateTime ToDateTime(long unixTime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTime).ToLocalTime();
            return dtDateTime;
        }

        public static long ZamanGetir()
        {
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long nowTicks = DateTime.Now.Ticks;
            long tmStamp = (nowTicks - epochTicks) / TimeSpan.TicksPerSecond;
            return tmStamp;
        }

        public static string MerkleKokYarat(string[] islemKarmalari)
        {
            while (true)
            {
                if (islemKarmalari.Length == 0) return string.Empty;

                if (islemKarmalari.Length == 1) return islemKarmalari[0];

                List<string> yeniKarmaListesi = new List<string>();

                int uzunluk = islemKarmalari.Length % 2 != 0 ? islemKarmalari.Length - 1 : islemKarmalari.Length;

                for (int i = 0; i < uzunluk; i += 2)
                    yeniKarmaListesi.Add(BirlesikYaprakKarma(islemKarmalari[i], islemKarmalari[i + 1]));

                if (uzunluk < islemKarmalari.Length)
                    yeniKarmaListesi.Add(BirlesikYaprakKarma(islemKarmalari[^1], islemKarmalari[^1]));

                islemKarmalari = yeniKarmaListesi.ToArray();
            }
        }


        static string BirlesikYaprakKarma(string yaprak1, string yaprak2)
        {
            byte[] yaprak1Byte = HexToBytes(yaprak1);

            byte[] yaprak2Byte = HexToBytes(yaprak2);

            var concatKarma = yaprak1Byte.Concat(yaprak2Byte).ToArray();
            SHA256 sha256 = SHA256.Create();
            byte[] sendKarma = sha256.ComputeHash(sha256.ComputeHash(concatKarma));

            return BytesToHex(sendKarma).ToLower();
        }
        
        public static double ToplamUcretGetir(List<Islem> islemler) =>
            islemler.AsEnumerable().Sum(_ => _.Ucret);
         

        public static double ToplamTutarGetir(List<Islem> islemler) =>
            islemler.AsEnumerable().Sum(_ => _.Tutar);
            

        public static string IslemKarmasiOlustur(Islem islem)
        {
            var islemKarma = KarmaUret(KarmaUret(
                islem.ZamanDamgasi +
                islem.Gonderen +
                islem.Tutar +
                islem.Ucret +
                islem.Alici));
            return islemKarma;
        }

        public static void BlokYazdir(Blok blok)
        {
            Console.WriteLine("\n===========\nYeni blok oluşturuldu!");
            Console.WriteLine(" = Yukseklik    : {0}", blok.Yukseklik);
            Console.WriteLine(" = Versiyon     : {0}", blok.Versiyon);
            Console.WriteLine(" = Onceki Karma : {0}", blok.OncekiKarma);
            Console.WriteLine(" = Karma        : {0}", blok.Karma);
            Console.WriteLine(" = Merkle Karma : {0}", blok.MerkleKoku);
            Console.WriteLine(" = Zaman Damgasi: {0}", ToDateTime(blok.ZamanDamgasi));
            Console.WriteLine(" = Zorkluk      : {0}", blok.Zorluk);
            Console.WriteLine(" = Dogrulayici  : {0}", blok.Dogrulayici);
            Console.WriteLine(" = Nonce        : {0}", blok.Nonce);
            Console.WriteLine(" = Islem Adedi  : {0}", blok.IslemAdedi);
            Console.WriteLine(" = Miktar       : {0}", blok.ToplamTutar);
            Console.WriteLine(" = Odul         : {0}", blok.ToplamOdul);
            Console.WriteLine(" = Boyut        : {0}", blok.Boyut);
            Console.WriteLine(" = Insa Suresi  : {0}", blok.InsaSuresi);
            Console.WriteLine(" = Imza         : {0}", blok.Imza);
			Console.WriteLine("\n=====================================\n");
		}

        public static void IslemYazdir(Islem islem)
        {
			Console.WriteLine("\n===========\nİşme başarıyla alındı!");
			Console.WriteLine(" = Zaman Damgasi  : {0}", ToDateTime(islem.ZamanDamgasi));
			Console.WriteLine(" = Yukseklik      : {0}", islem.Yukseklik);
			Console.WriteLine(" = Islem Tipi     : {0}", islem.IslemTipi);
			Console.WriteLine(" = Tutar          : {0}", islem.Tutar);
			Console.WriteLine(" = Ucret          : {0}", islem.Ucret);
			Console.WriteLine(" = Karma          : {0}", islem.Karma);
			Console.WriteLine(" = Gonderen       : {0}", islem.Gonderen);
			Console.WriteLine(" = Genel Anahtar  : {0}", islem.GenelAnahtar);
			Console.WriteLine(" = Imza           : {0}", islem.Imza);
			Console.WriteLine(" = Alici          : {0}", islem.Alici);
			Console.WriteLine("\n=====================================\n");
		}

    }
}
