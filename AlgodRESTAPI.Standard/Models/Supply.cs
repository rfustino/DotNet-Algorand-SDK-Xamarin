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
    public class Supply : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int onlineMoney;
        private int round;
        private int totalMoney;

        /// <summary>
        /// OnlineMoney
        /// </summary>
        [JsonProperty("onlineMoney")]
        public int OnlineMoney 
        { 
            get 
            {
                return this.onlineMoney; 
            } 
            set 
            {
                this.onlineMoney = value;
                onPropertyChanged("OnlineMoney");
            }
        }

        /// <summary>
        /// Round
        /// </summary>
        [JsonProperty("round")]
        public int Round 
        { 
            get 
            {
                return this.round; 
            } 
            set 
            {
                this.round = value;
                onPropertyChanged("Round");
            }
        }

        /// <summary>
        /// TotalMoney
        /// </summary>
        [JsonProperty("totalMoney")]
        public int TotalMoney 
        { 
            get 
            {
                return this.totalMoney; 
            } 
            set 
            {
                this.totalMoney = value;
                onPropertyChanged("TotalMoney");
            }
        }
    }
} 