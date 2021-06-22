using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Json;
using System.Collections.Generic;

namespace crypto_sentiment.Data
{
    class TweetAPIService
    {


        public async Task<string> GetTweetSentiment(string coin)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5001/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/"+coin);
                if (response.IsSuccessStatusCode)
                {
                    string resp = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(resp);
                    return resp;
                }else{
                    Console.WriteLine("FAILURE!");
                    return null;
                }
               
            }
        }
    }
}