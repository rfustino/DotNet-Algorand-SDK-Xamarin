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
    public class TransactionList : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.Transaction> transactions;

        /// <summary>
        /// TransactionList is a list of transactions
        /// </summary>
        [JsonProperty("transactions")]
        public List<Models.Transaction> Transactions 
        { 
            get 
            {
                return this.transactions; 
            } 
            set 
            {
                this.transactions = value;
                onPropertyChanged("Transactions");
            }
        }
    }
} 