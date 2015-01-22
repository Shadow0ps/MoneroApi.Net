﻿using Newtonsoft.Json;

namespace Jojatekok.MoneroAPI
{
    public class Transaction
    {
        private string _transactionId;
        private bool _isAmountSpendable;

        [JsonProperty("amount")]
        public ulong Amount { get; internal set; }

        [JsonProperty("tx_hash")]
        public string TransactionId {
            get { return _transactionId; }

            internal set {
                // Discard the '<' and '>' characters
                _transactionId = value.Substring(1, value.Length - 2);
            }
        }

        [JsonProperty("spent")]
        public bool IsAmountSpendable {
            get { return _isAmountSpendable; }
            internal set { _isAmountSpendable = !value; }
        }

        public TransactionType Type { get; internal set; }

        public uint Number { get; internal set; }

        [JsonProperty("global_index")]
        public ulong GlobalIndex { get; internal set; }
    }
}
