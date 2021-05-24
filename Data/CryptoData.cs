using System;

namespace crypto_sentiment.Data
{
    public class CryptoFormat
    {
        public string cryptoID  { get; set; }
        public DateTime date { get; set; }

        
        public int currencyID {get;set;}

        public int currPrice { get; set; }

        public string symbol {get; set;}

        public string slug {get;set;}

        public long market_cap {get;set;}
    }
}