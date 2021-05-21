using System.ComponentModel.DataAnnotations;
using System;


namespace crypto_sentiment.Models {
    public class CryptoData
    {
        public DateTime Date { get; set; }

        [Required]
        public int currencyID {get;set;}

        [Required]
        public int currPrice { get; set; }

        [Required]
        public string symbol {get; set;}

        public string slug {get;set;}

        public double market_cap {get;set;}
    }
}