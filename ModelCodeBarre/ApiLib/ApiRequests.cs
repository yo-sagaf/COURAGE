using ModelCodeBarre;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib
{
    public static class ApiRequests
    {
        private static string baseUri = "https://localhost:44328/";
        private static HttpClient client = new HttpClient();

        public static async Task<List<Article>> GetArticles()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{baseUri}api/article/all");
            var alertResponse = await client.SendAsync(requestMessage);

            if (alertResponse.StatusCode != HttpStatusCode.OK) throw new NotSupportedException();

            var alertResponseString = await alertResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Article>>(alertResponseString);
        }

        
        public static async Task<List<Article>> GetArticlesByCodeBarre(string codeBarre)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{baseUri}api/article/byCodeBarre/{codeBarre}");
            var alertResponse = await client.SendAsync(requestMessage);

            if (alertResponse.StatusCode != HttpStatusCode.OK) throw new NotSupportedException();

            var alertResponseString = await alertResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Article>>(alertResponseString);
        }
        
        public static bool addArticle(Article article)
        {
            var json = JsonConvert.SerializeObject(article);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{baseUri}api/article/add");
            requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var alertResponse = client.SendAsync(requestMessage).Result;

            return alertResponse.IsSuccessStatusCode;
        }
    }
}
