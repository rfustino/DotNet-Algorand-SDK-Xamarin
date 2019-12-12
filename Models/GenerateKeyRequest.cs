/*
 * ForKMDHTTPAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ForKMDHTTPAPI.Standard;
using ForKMDHTTPAPI.Standard.Utilities;


namespace ForKMDHTTPAPI.Standard.Models
{
    public class GenerateKeyRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? displayMnemonic;
        private string walletHandleToken;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("display_mnemonic")]
        public bool? DisplayMnemonic 
        { 
            get 
            {
                return this.displayMnemonic; 
            } 
            set 
            {
                this.displayMnemonic = value;
                onPropertyChanged("DisplayMnemonic");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("wallet_handle_token")]
        public string WalletHandleToken 
        { 
            get 
            {
                return this.walletHandleToken; 
            } 
            set 
            {
                this.walletHandleToken = value;
                onPropertyChanged("WalletHandleToken");
            }
        }
    }
} 