using System;

namespace crypto_sentiment.Data
{
    public class CryptoData
    {
        public DateTime Date { get; set; }

        public int currPrice { get; set; }

        public string symbol {get; set;}

        public string slug {get;set;}

        public double market_cap {get;set;}
    }
}