using NBitcoin;
using NBitcoin.DataEncoders;
using System.Security.Cryptography;

namespace RecycleCoinServer
{
    /**
    * Kripto para birimleri, Asimetrik Şifreleme kullanılarak oluşturulan 
    * sahiplik kanıtı olarak ortak anahtar ve özel anahtar çiftlerini 
    * kullanır.
    * Cüzdan her işlem için bir imza atacak ve ardından açık anahtarla 
    * birlikte işlemin kendisi blok zinciri sunucusuna gönderilecektir.
    * Düğüm, alınan işlemin imzasını doğrulayacaktır.
    * Cüzdanlar ve blok zinciri düğümleri arasında, 
    * gRPC ile oluşturulan hizmetleri kullanarak veri alışverişi yapılır.
    **/
    public class AnahtarCifti
    {
        public ExtKey GizliAnahtar { get; set; }
        public ExtPubKey GenelAnahtar { get; set; }
        public string GenelAnahtarHex { get; set; }
    }
    public class Cuzdan
    {
        public AnahtarCifti AnahtarCifti { get; set; }
        public Mnemonic Animsatici { get; set; }
        public string ParolaMetni { get; set; }

        public Cuzdan()
        {
            Animsatici = new Mnemonic(Wordlist.English, WordCount.Twelve);
            ParolaMetni = Animsatici.ToString();
            AnahtarCifti = AnahtarCiftiUret(Animsatici, 0);
        }

        public Cuzdan(string parolaMetni)
        {
            Animsatici = new Mnemonic(parolaMetni);
            ParolaMetni = Animsatici.ToString();
            AnahtarCifti = AnahtarCiftiUret(Animsatici, 0);
        }

        public string GenelAnahtarGetir()
        {
          return AnahtarCifti.GenelAnahtarHex;
        }

        public AnahtarCifti AnahtarCiftiGetir() =>
            AnahtarCifti;

        public string AdresGetir()
        {
            byte[] baytlar = SHA256.Create()
                .ComputeHash(AnahtarCifti.GenelAnahtar.ToBytes());
            return Encoders.Base58.EncodeData(baytlar);
        }

        public string Imzala(string verininKarmasi) =>
            AnahtarCifti.GizliAnahtar.PrivateKey
            .SignMessage(verininKarmasi);


        public static bool imzaDogrula(
            string genelAnahtarHex, 
            string imza, 
            string verininKarmasi)
        {
            var genelAnahtar = new PubKey(genelAnahtarHex);
            return genelAnahtar.VerifyMessage(verininKarmasi, imza);
        }

        private AnahtarCifti AnahtarCiftiUret(Mnemonic animsatici, int yol)
        {
            var anaAnahtar = animsatici.DeriveExtKey();
            ExtPubKey anaGenelAnahtar = anaAnahtar.Neuter();
            ExtKey turetilmisGizliAnahtar = anaAnahtar.Derive((uint)yol);
            ExtPubKey turetilmisGenelAnahtar = anaGenelAnahtar.Derive((uint)yol);

            var genelAnahtarHex = turetilmisGenelAnahtar.PubKey.ToHex();
            var anahtarCifti = new AnahtarCifti()
            {
                GizliAnahtar = turetilmisGizliAnahtar,
                GenelAnahtar = turetilmisGenelAnahtar,
                GenelAnahtarHex = genelAnahtarHex
            };

            return anahtarCifti;
        }
    }
}
