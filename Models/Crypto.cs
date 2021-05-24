using System.ComponentModel.DataAnnotations;
using System;


namespace crypto_sentiment.Models {
    public class CryptoData
    {
        

        [Key]
        public string cryptoID  { get; set; }

        [Required]
        public double currPrice { get; set; }

        [Required]
        public int currencyID {get;set;}

        public DateTime date { get; set; }

        public long market_cap {get;set;}

        public string slug {get;set;}

        [Required]
        public string symbol {get; set;}

        

       
    }
}