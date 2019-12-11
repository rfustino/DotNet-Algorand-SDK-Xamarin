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
    public class AssetConfigTransactionType : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? id;
        private Models.AssetParamsSpecifiesTheParametersForAnAsset mparams;

        /// <summary>
        /// AssetID is the asset being configured (or empty if creating)
        /// </summary>
        [JsonProperty("id")]
        public int? Id 
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
        [JsonProperty("params")]
        public Models.AssetParamsSpecifiesTheParametersForAnAsset Params 
        { 
            get 
            {
                return this.mparams; 
            } 
            set 
            {
                this.mparams = value;
                onPropertyChanged("Params");
            }
        }
    }
} 