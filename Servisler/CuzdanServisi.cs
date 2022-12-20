using NBitcoin;
using NBitcoin.DataEncoders;
using System.Security.Cryptography;
using System;
using RecycleCoinServer.Diger;

namespace RecycleCoinServer.Servisler
{

    public class AnahtarCifti
    {
        public ExtKey GizliAnahtar { get; set; }
        public ExtPubKey GenelAnahtar { get; set; }
        public string GenelAnahtarHex { get; set; }
    }


    public class CuzdanServisi
    {
        public Cuzdan _cuzdan;

        public CuzdanServisi()
        {
            var animsatici = DotNetEnv.Env.GetString("NODE_PASSPHRASE");
            if (animsatici != null) _cuzdan = new Cuzdan(animsatici);
            else _cuzdan = new Cuzdan();
        }
            

        public void Baslat()
        {
            Console.WriteLine("..... Cüzdan hizmeti başlatılıyor");
            Console.WriteLine("..... Cüzdan hizmeti hazır");
        }

        public string Genesis1GenelAnahtarGetir()
        {
            var animsaticti = Sabitler.GENESİS_HESAP1_MNEMONIC.Trim();
            Cuzdan genesisCuzdan = new Cuzdan(animsaticti);
            return genesisCuzdan.GenelAnahtarGetir();
        }
        
        public string Genesis2GenelAnahtarGetir()
        {
            var animsaticti = Sabitler.GENESİS_HESAP2_MNEMONIC.Trim();
            Cuzdan genesisCuzdan = new Cuzdan(animsaticti);
            return genesisCuzdan.GenelAnahtarGetir();
        }

        public string Genesis1Imza(string karma)
        {
            var animsaticti = Sabitler.GENESİS_HESAP1_MNEMONIC;
            Cuzdan genesisCuzdan = new Cuzdan(animsaticti);
            return genesisCuzdan.Imzala(karma);
        }
        
        public string Genesis2Imza(string karma)
        {
            var animsaticti = Sabitler.GENESİS_HESAP2_MNEMONIC;
            Cuzdan genesisCuzdan = new Cuzdan(animsaticti);
            return genesisCuzdan.Imzala(karma);
        }
    }
}
