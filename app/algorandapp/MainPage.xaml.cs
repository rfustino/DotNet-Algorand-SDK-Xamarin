using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AlgodRESTAPI.Standard.Models;
using Chaos.NaCl;
using System.IO;

namespace algorandapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Account myAccountInfo;
        public string myPublicKey;
        public VersionContainsTheCurrentAlgodVersion myVersion;
        public AlgodRESTAPI.Standard.AlgodRESTAPIClient client;
        public Block myBlock;
        public Transaction mtTxn;
        public static readonly int PublicKeySizeInBytes = 32;
        public static readonly int SignatureSizeInBytes = 64;
        public static readonly int ExpandedPrivateKeySizeInBytes = 32 * 2;
        public static readonly int PrivateKeySeedSizeInBytes = 32;
        public static readonly int SharedKeySizeInBytes = 32;
        public static readonly int ALGORAND_CHECKSUM_BYTE_LENGTH = 4;
        public static readonly int ALGORAND_ADDRESS_LENGTH = 58;
        public MainPage()
        {
            InitializeComponent();
        }

        public async void myButton_click(object sender, EventArgs e)
        {
       // kmd
       //      ForKMDHTTPAPI.Standard.Configuration.XKMDAPIToken = "X-KMD-API-Token";
       //      ForKMDHTTPAPI.Standard.ForKMDHTTPAPIClient clientkmd = new ForKMDHTTPAPI.Standard.ForKMDHTTPAPIClient();
       // Algod
            var address = "http://hackathon.algodev.network:9100";
            AlgodRESTAPI.Standard.Configuration.XAlgoAPIToken = "ef920e2e7e002953f4b29a8af720efe8e4ecc75ff102b165e0472834b25832c1";
            AlgodRESTAPI.Standard.Configuration.BaseUri = new Uri(address).ToString();
            client = new AlgodRESTAPI.Standard.AlgodRESTAPIClient();
            myVersion = await client.Client.GetVersionAsync();
            myLabel.Text = "Build Version = "+ myVersion.Build.Major.ToString() +"." + myVersion.Build.Minor.ToString();
            myLabel2.Text = "GenesisId = " + myVersion.GenesisId.ToString() ;
        }


        public async void myButtonGenerateAccount_click(object sender, EventArgs e)
        {            
            var m = new byte[100];
            var seed = new byte[32];
            byte[] privateKey;
            byte[] publicKey;
            Random random = new Random();
            random.NextBytes(seed);
            // create public/private key from random seed
            Chaos.NaCl.Ed25519.KeyPairFromSeed(out publicKey, out privateKey, seed);
            var sig = Chaos.NaCl.Ed25519.Sign(m, privateKey);
            Ed25519.Sign(m, privateKey);
            var checksum = Chaos.NaCl.Ed25519.PublicKeyFromSeed(publicKey);
            var mychecksum = new byte[4];
            //copy off last 4 of checksum for mychecksum
            Buffer.BlockCopy(checksum, 28, mychecksum, 0, 4);
            //concat the streams
            var s = new MemoryStream();
            s.Write(checksum, 0, checksum.Length);
            s.Write(mychecksum, 0, mychecksum.Length);
            var combinedarray = s.ToArray();
            // convert the byte array to a Base32 string
            myPublicKey = KodeAid.Base32Encoder.EncodeBytes(combinedarray);
            // get rid of the ====== at end of string
            myPublicKey = myPublicKey.Substring(0, ALGORAND_ADDRESS_LENGTH);
            myLabel.Text = "Public Key = " + myPublicKey;
            myLabel2.Text = "";
//            myLabel2.Text = "Private Key length = " + (privateKey.Length);

            // run javascript in c# util?
            //         var engine = new Jurassic.ScriptEngine();
            //          // ALGORAND_ADDRESS_LENGTH const ALGORAND_ADDRESS_LENGTH = 58;
            //          // PUBLIC_KEY_LENGTH publicKey.Length;
            //          // nacl.PUBLIC_KEY_LENGTH - ALGORAND_CHECKSUM_BYTE_LENGTH const ALGORAND_CHECKSUM_BYTE_LENGTH = 4;
            //          engine.Evaluate("function encode(address,publickeylength){let checksum = sha512.sha512_256.array(address);.slice((publickeylength) - 4, (publickeylength));let addr = base32.encode(utils.concatArrays(address, checksum));return addr.toString().slice(0, 58); // removing the extra '===='}");
            ////      Console.WriteLine(engine.CallGlobalFunction<int>("encode", publicKey));
            //         var publicKeyStr = engine.CallGlobalFunction<string>("encode", publicKey, publicKey.Length);

        }


        public async void myButtonClientInfo_click(object sender, EventArgs e)
        {
            myAccountInfo = await client.Client.GetAccountInformationAsync("WRTJ62AAOJ6W5XEXVUZ63D57IOI2XXRBBPB4RROQMHJEK4HW7EDWPXSP6Y");
        //    myAccountInfo = await client.Client.GetAccountInformationAsync(myPublicKey);
            
            Debug.Print(myAccountInfo.Address);
            Debug.Print(myAccountInfo.Amount.ToString());
            Debug.Print(myAccountInfo.Round.ToString());
            Debug.Print(myAccountInfo.Status);
            if (myAccountInfo.Thisassettotal != null)
                Debug.Print(myAccountInfo.Thisassettotal.ToString());
            if (myAccountInfo.Assets != null)
                Debug.Print(myAccountInfo.Assets.ToString());

            myLabel.Text = "Account Address = " + myAccountInfo.Address.ToString();
            myLabel2.Text = "Amount = " + myAccountInfo.Amount.ToString();
        }

        public async void myButtonBlock_click(object sender, EventArgs e)
        {
            //myBlock = await client.Client.GetBlockAsync(myAccountInfo.Round);
            myBlock = await client.Client.GetBlockAsync(3499281);
      
            Debug.Print(myBlock.Round.ToString());
            myLabel.Text = "Client Block = " + myBlock.Round.ToString();
            if (myBlock.Txns.Transactions == null)
            {
                myLabel2.Text = "Transaction Count = 0";
            }
            else
            {
            myLabel2.Text = "Transaction Count = " + myBlock.Txns.Transactions.Count();
            }
        }

        public async void myButtonTxInfo_click(object sender, EventArgs e)
        {
            mtTxn = await client.Client.GetTransactionAsync("KJ2AOIYYJNI36TIYP3BNR4L3SMNDUO3MPDTEH2IH3LOXQODBWNQA");
            Debug.Print("Tx= " + mtTxn.Tx.ToString());
            myLabel.Text = "Tx Info = " + mtTxn.Tx;
            myLabel2.Text = "Payment = " + mtTxn.Payment.Amount.ToString();
            //  "KJ2AOIYYJNI36TIYP3BNR4L3SMNDUO3MPDTEH2IH3LOXQODBWNQA"

        }
        //   crypto.FromPublicKey()
        //        const atoken = "ef920e2e7e002953f4b29a8af720efe8e4ecc75ff102b165e0472834b25832c1";
        //          const aserver = "http://hackathon.algodev.network";
        //        const aport = 9100;
        // tx id
        // 6CAO6FGWMFKKR7XY5EFWV3CISE633AXEEI6PHTFTCKR5GN5HG3LA

        // local
        // http://127.0.0.1:8080
        // "ec068ed68dc176e61a07b897c53835c6fb956271ce70aad3b204f0db6fa34f6d"
        //var crypto = new Rebex.Security.Cryptography.Ed25519();
        //var pk = crypto.GetPrivateKey();
        //      var crypto2 = new dotnetstandard_bip32.BIP32();
        //       (byte[] Key, byte[] ChainCode) = crypto2.GetMasterKeyFromSeed("distance industry stool brain creek dumb pigeon balcony undo tag capable interest coach infant remind lottery turtle garment believe tree acquire claim poverty above choice");
        //       Debug.Print(Key.ToString(), ChainCode.ToString());

        //var crypto3 = new dotnetstandard_bip39.BIP39();
        //var myseed = crypto3.MnemonicToSeedHex("distance industry stool brain creek dumb pigeon balcony undo tag capable interest coach infant remind lottery turtle garment believe tree acquire claim poverty above choice", "");

        //var mywordlist = new dotnetstandard_bip39.BIP39Wordlist();
        //crypto3.GenerateMnemonic(0, mywordlist);
        //   var myBlockInfo = client.Client.GetBlock(3322109);
        //   Debug.Print(myBlockInfo.Round.ToString());
        //           string apiUrl = null;
        //            if (Device.RuntimePlatform == Device.Android)
        //                apiUrl = “http://10.0.2.2:5001/api“;
        //   else if (Device.RuntimePlatform == Device.iOS)
        //               apiUrl = “http://localhost:5001/api“;
        //   else
        //               throw new UnsupportedPlatformException();

    }


}

