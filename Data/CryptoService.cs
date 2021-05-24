using System;
using System.Net;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using crypto_sentiment.Data;
using crypto_sentiment.Models;
using Microsoft.EntityFrameworkCore;

namespace crypto_sentiment.Data
{
    public class CryptoService
    {
        private static string COIN_MARKET_API_KEY = Secrets.getCoinMarketKey();


        public List<CryptoData> refreshCryptoData(DateTime startDate)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            URL.Query = queryString.ToString();

            var client = new WebClient();
            List<CryptoData> dataList = new List<CryptoData>();
            client.Headers.Add("X-CMC_PRO_API_KEY", COIN_MARKET_API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string resp = client.DownloadString(URL.ToString());
            var cryptoObject = JObject.Parse(resp);
            Console.WriteLine(((JArray)cryptoObject["data"]).Count);

            for (int i = 0; i < ((JArray)cryptoObject["data"]).Count; i++) 
            {

                
                CryptoData respData = new CryptoData
                {
                    date =  DateTime.Now,
                    cryptoID = Guid.NewGuid().ToString(),
                    currencyID = (int)cryptoObject["data"][i]["id"],
                    currPrice = (double)cryptoObject["data"][i]["quote"]["USD"]["price"],
                    symbol = (string)cryptoObject["data"][i]["symbol"],
                    slug = (string)cryptoObject["data"][i]["slug"],
                    market_cap = (long)cryptoObject["data"][i]["quote"]["USD"]["market_cap"]
                };
                dataList.Add(respData);
            }

            return dataList;


            // CryptoData respData = new CryptoData
            // {
            //     date =  DateTime.Now,
            //     cryptoID = Guid.NewGuid().ToString(),
            //     currencyID = (int)cryptoObject["data"][0]["id"],
            //     currPrice = (int)cryptoObject["data"][0]["quote"]["USD"]["price"],
            //     symbol = (string)cryptoObject["data"][0]["symbol"],
            //     slug = (string)cryptoObject["data"][0]["slug"],
            //     market_cap = (long)cryptoObject["data"][0]["quote"]["USD"]["market_cap"]
            // };






            // return Task.FromResult(new CryptoData
            // {
            //     date = startDate,
            //     currPrice = (int)cryptoObject["data"][0]["quote"]["USD"]["price"],
            //     cryptoID = "1",
            //     symbol = (string)cryptoObject["data"][0]["symbol"],
            //     slug = (string)cryptoObject["data"][0]["slug"],
            //     market_cap = (long)cryptoObject["data"][0]["quote"]["USD"]["market_cap"]
            // });

        }

    }

}