using System;
using System.Net;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;


namespace crypto_sentiment.Data
{
    public class CryptoService
    {
        private static string API_KEY = "";

        // public static void Main(string[] args)
        // {
        //     try
        //     {
        //     Console.WriteLine(getLatestCryptoData());
        //     }
        //     catch (WebException e)
        //     {
        //     Console.WriteLine(e.Message);
        //     }
        // }

        public static Task<CryptoData> getCryptoData(DateTime startDate)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string resp = client.DownloadString(URL.ToString());
            var cryptoObject = JObject.Parse(resp);
            //Console.WriteLine(cryptoObject["data"][0]);


            return Task.FromResult(new CryptoData
            {
                Date = startDate,
                currPrice = (int)cryptoObject["data"][0]["quote"]["USD"]["price"],
                symbol = (string)cryptoObject["data"][0]["symbol"],
                slug = (string)cryptoObject["data"][0]["slug"],
                market_cap = (double)cryptoObject["data"][0]["quote"]["USD"]["market_cap"]
            });

        }

    }

}