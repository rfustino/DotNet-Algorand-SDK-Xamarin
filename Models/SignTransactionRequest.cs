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
    public class SignTransactionRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string transaction;
        private string walletHandleToken;
        private string walletPassword;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction 
        { 
            get 
            {
                return this.transaction; 
            } 
            set 
            {
                this.transaction = value;
                onPropertyChanged("Transaction");
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