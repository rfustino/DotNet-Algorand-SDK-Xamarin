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
    public class InitWalletHandleTokenRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string walletId;
        private string walletPassword;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("wallet_id")]
        public string WalletId 
        { 
            get 
            {
                return this.walletId; 
            } 
            set 
            {
                this.walletId = value;
                onPropertyChanged("WalletId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("wallet_password")]
        public string WalletPassword 
        { 
            get 
            {
                return this.walletPassword; 
            } 
            set 
            {
                this.walletPassword = value;
                onPropertyChanged("WalletPassword");
            }
        }
    }
} 