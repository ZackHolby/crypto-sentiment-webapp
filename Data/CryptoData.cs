using System;

namespace crypto_sentiment.Data
{
    public class CryptoData
    {
        public string cryptoID  { get; set; }
        public DateTime Date { get; set; }

        
        public int currencyID {get;set;}

        public int currPrice { get; set; }

        public string symbol {get; set;}

        public string slug {get;set;}

        public double market_cap {get;set;}
    }
}