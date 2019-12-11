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
    public class Account : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string address;
        private int amount;
        private int amountwithoutpendingrewards;
        private object assets;
        private Models.Participation participation;
        private int pendingrewards;
        private int rewards;
        private int round;
        private string status;
        private object thisassettotal;

        /// <summary>
        /// Address indicates the account public key
        /// </summary>
        [JsonProperty("address")]
        public string Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Amount indicates the total number of MicroAlgos in the account
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// AmountWithoutPendingRewards specifies the amount of MicroAlgos in
        /// the account, without the pending rewards.
        /// </summary>
        [JsonProperty("amountwithoutpendingrewards")]
        public int Amountwithoutpendingrewards 
        { 
            get 
            {
                return this.amountwithoutpendingrewards; 
            } 
            set 
            {
                this.amountwithoutpendingrewards = value;
                onPropertyChanged("Amountwithoutpendingrewards");
            }
        }

        /// <summary>
        /// Assets specifies the holdings of assets by this account,
        /// indexed by the asset ID.
        /// </summary>
        [JsonProperty("assets")]
        public object Assets 
        { 
            get 
            {
                return this.assets; 
            } 
            set 
            {
                this.assets = value;
                onPropertyChanged("Assets");
            }
        }

        /// <summary>
        /// Participation Description
        /// </summary>
        [JsonProperty("participation")]
        public Models.Participation Participation 
        { 
            get 
            {
                return this.participation; 
            } 
            set 
            {
                this.participation = value;
                onPropertyChanged("Participation");
            }
        }

        /// <summary>
        /// PendingRewards specifies the amount of MicroAlgos of pending
        /// rewards in this account.
        /// </summary>
        [JsonProperty("pendingrewards")]
        public int Pendingrewards 
        { 
            get 
            {
                return this.pendingrewards; 
            } 
            set 
            {
                this.pendingrewards = value;
                onPropertyChanged("Pendingrewards");
            }
        }

        /// <summary>
        /// Rewards indicates the total rewards of MicroAlgos the account has received, including pending rewards.
        /// </summary>
        [JsonProperty("rewards")]
        public int Rewards 
        { 
            get 
            {
                return this.rewards; 
            } 
            set 
            {
                this.rewards = value;
                onPropertyChanged("Rewards");
            }
        }

        /// <summary>
        /// Round indicates the round for which this information is relevant
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
        /// Status indicates the delegation status of the account's MicroAlgos
        /// Offline - indicates that the associated account is delegated.
        /// Online  - indicates that the associated account used as part of the delegation pool.
        /// NotParticipating - indicates that the associated account is neither a delegator nor a delegate.
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// AssetParams specifies the parameters of assets created by this account.
        /// </summary>
        [JsonProperty("thisassettotal")]
        public object Thisassettotal 
        { 
            get 
            {
                return this.thisassettotal; 
            } 
            set 
            {
                this.thisassettotal = value;
                onPropertyChanged("Thisassettotal");
            }
        }
    }
} 