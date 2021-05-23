using System;
using System.Net;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using crypto_sentiment.Data;



namespace crypto_sentiment.Data
{
    public class CryptoService
    {
        private static string COIN_MARKET_API_KEY = Secrets.getCoinMarketKey();


        public static Task<CryptoData> getCryptoData(DateTime startDate)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", COIN_MARKET_API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string resp = client.DownloadString(URL.ToString());
            var cryptoObject = JObject.Parse(resp);
            //Console.WriteLine(cryptoObject["data"][0]);


            return Task.FromResult(new CryptoData
            {
                date = startDate,
                currPrice = (int)cryptoObject["data"][0]["quote"]["USD"]["price"],
                cryptoID = "1",
                symbol = (string)cryptoObject["data"][0]["symbol"],
                slug = (string)cryptoObject["data"][0]["slug"],
                market_cap = (long)cryptoObject["data"][0]["quote"]["USD"]["market_cap"]
            });

        }

    }

}