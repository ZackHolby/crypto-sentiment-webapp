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

        public async Task<string> getSenti(string coin){
            using (var client = new HttpClient()){
                HttpResponseMessage response = await client.GetAsync("https://twittersentiapi.azurewebsites.net/api/"+coin);
                 if (response.IsSuccessStatusCode)
                {
                    string resp = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("NEW Sentiment: "+resp);
                    return resp;
                }else{
                    Console.WriteLine("FAILURE!");
                    return null;
                }
            }
        }
        public async Task<string> GetTweetSentiment(string coin)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:3000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/"+coin);
                if (response.IsSuccessStatusCode)
                {
                    string resp = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Sentiment: "+resp);
                    return resp;
                }else{
                    Console.WriteLine("FAILURE!");
                    return null;
                }
               
            }
        }
    }
}