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
            
  
            var resp = await client.SearchV2.SearchTweetsAsync("BTC");

            var symb = "No tweets found for symbol "+cryptoSymbol;

            
            var classifier = new GroupDocs.Classification.SentimentClassifier();


            foreach(var tweet in resp.Tweets){
            
                symb = cryptoSymbol;
                Console.WriteLine(tweet.Text);
                string tweetText = tweet.Text;
                int totalLen = 0;
                if(tweetText.Length < 100){
                    totalLen = tweetText.Length;
                }else{
                    totalLen = 100;
                }
                var response = classifier.Classify(tweetText.Substring(0,totalLen));
                Console.WriteLine($"{response.BestClassName}: {response.BestClassProbability}");

            }

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