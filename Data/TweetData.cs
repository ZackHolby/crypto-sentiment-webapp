using System;

namespace crypto_sentiment.Data
{
    public class TweetData
    {
        public string tweetID  { get; set; }
        public DateTime date { get; set; }

        public string symbol {get;set;}

        
        public double sentiment {get;set;}

    }
}