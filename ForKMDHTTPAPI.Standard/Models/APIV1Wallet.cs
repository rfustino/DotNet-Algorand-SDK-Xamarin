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
    public class APIV1Wallet : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string driverName;
        private int? driverVersion;
        private string id;
        private bool? mnemonicUx;
        private string name;
        private List<string> supportedTxs;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("driver_name")]
        public string DriverName 
        { 
            get 
            {
                return this.driverName; 
            } 
            set 
            {
                this.driverName = value;
                onPropertyChanged("DriverName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("driver_version")]
        public int? DriverVersion 
        { 
            get 
            {
                return this.driverVersion; 
            } 
            set 
            {
                this.driverVersion = value;
                onPropertyChanged("DriverVersion");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mnemonic_ux")]
        public bool? MnemonicUx 
        { 
            get 
            {
                return this.mnemonicUx; 
            } 
            set 
            {
                this.mnemonicUx = value;
                onPropertyChanged("MnemonicUx");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("supported_txs")]
        public List<string> SupportedTxs 
        { 
            get 
            {
                return this.supportedTxs; 
            } 
            set 
            {
                this.supportedTxs = value;
                onPropertyChanged("SupportedTxs");
            }
        }
    }
} 