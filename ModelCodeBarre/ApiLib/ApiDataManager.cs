using ModelCodeBarre;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ApiLib
{
    public class ApiDataManager : IDataManager
    {
        static HttpClient client;

        public ApiDataManager()
        {
            client = new HttpClient();
        }

        public bool addArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public Article findArticle(string codeBarre)
        {
            throw new NotImplementedException();
        }

        public List<Article> getArticles()
        {
            return ApiRequests.GetArticles().Result;
        }
    }
}
