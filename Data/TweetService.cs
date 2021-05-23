using System;
using System.Net;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using crypto_sentiment.Data;

using Tweetinvi;


namespace crypto_sentiment.Data
{
    public class TwitterService
    {
        private static string TWITTER_CONSUMER_KEY = Secrets.getTwitterConsumerKey();
        private static string TWITTER_CONSUMER_SEC = Secrets.getTwitterConsumerSec();
        private static string TWITTER_ACCESS_TOK = Secrets.getTwitterAccessTok();
        private static string TWITTER_ACCESS_TOK_SEC = Secrets.getTwitterAccessTokSec();



        public static Task<TweetData> getTweetData(DateTime startDate)
        {
            var userClient = new TwitterClient(TWITTER_CONSUMER_KEY,TWITTER_CONSUMER_SEC,TWITTER_ACCESS_TOK,TWITTER_ACCESS_TOK_SEC);
  

            return Task.FromResult(new TweetData
            {
                date = startDate,
                tweetID = "7070",
                symbol = "ETH",
                sentiment = 3.0
            });

        }

    }

}