using System;
using System.Net;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using crypto_sentiment.Data;

using Tweetinvi;
using GroupDocs.Classification;
using System.Text.Json.Serialization;


namespace crypto_sentiment.Data
{
    public class TwitterService
    {
        private static string TWITTER_CONSUMER_KEY = Secrets.getTwitterConsumerKey();
        private static string TWITTER_CONSUMER_SEC = Secrets.getTwitterConsumerSec();
        private static string TWITTER_ACCESS_TOK = Secrets.getTwitterAccessTok();
        private static string TWITTER_ACCESS_TOK_SEC = Secrets.getTwitterAccessTokSec();



        public static async Task<TweetData> getTweetData(DateTime startDate, String cryptoSymbol)
        {
            var client = new TwitterClient(TWITTER_CONSUMER_KEY,TWITTER_CONSUMER_SEC,TWITTER_ACCESS_TOK,TWITTER_ACCESS_TOK_SEC);
            
  
            //var resp = await client.SearchV2.SearchTweetsAsync("BTC");

            // var stream = client.Streams.CreateTweetStream();
            // stream.AddLanguageFilter("en");
            // stream.AddTrack("hello world");


            // stream.EventReceived += (sender, eventReceived) =>
            // {
            //     Console.WriteLine(eventReceived.Json);
            // };
            // await stream.StartMatchingAllConditionsAsync("https://stream.twitter.com/1.1/statuses/sample.json");

            // var symb = "No tweets found for symbol "+cryptoSymbol;

            


            // foreach(var tweet in resp.Tweets){
            
            //     symb = cryptoSymbol;
            //     Console.WriteLine(tweet.Text);

            // }

            return new TweetData
            {
                date = startDate,
                tweetID = "1234",
                symbol = symb,
                sentiment = 3.0
            };

        }

    }

}