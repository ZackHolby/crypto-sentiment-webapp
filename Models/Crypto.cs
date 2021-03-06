using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;


namespace crypto_sentiment.Models {
    public class CryptoData
    {


        [Key]
        public string cryptoID { get; set; }

        [Required]
        public double currPrice { get; set; }

        
        [Required]
        public int currencyID { get; set; }

        public DateTime date { get; set; }

        public long marketCap { get; set; }

        public string slug { get; set; }

        public string symbol { get; set; }

        public double percentChange24 {get;set;}




    }
}