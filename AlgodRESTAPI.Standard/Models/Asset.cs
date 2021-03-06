/*
 * AlgodRESTAPI.Standard
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
using AlgodRESTAPI.Standard;
using AlgodRESTAPI.Standard.Utilities;


namespace AlgodRESTAPI.Standard.Models
{
    public class Asset : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int assetIndex;
        private Models.AssetParamsSpecifiesTheParametersForAnAsset assetParams;

        /// <summary>
        /// AssetIndex is the unique asset identifier
        /// </summary>
        [JsonProperty("AssetIndex")]
        public int AssetIndex 
        { 
            get 
            {
                return this.assetIndex; 
            } 
            set 
            {
                this.assetIndex = value;
                onPropertyChanged("AssetIndex");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AssetParams")]
        public Models.AssetParamsSpecifiesTheParametersForAnAsset AssetParams 
        { 
            get 
            {
                return this.assetParams; 
            } 
            set 
            {
                this.assetParams = value;
                onPropertyChanged("AssetParams");
            }
        }
    }
} 