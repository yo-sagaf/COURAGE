using ModelCodeBarre;
using System;

namespace Test_Api_Manager
{
    class test_apimanager
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager(new ApiLib.DbDataManager());

            var article = mgr.findArticle("AAAA");

            Console.WriteLine(article != null ? article.ToString() : "pas d'article avec ce code");

            article = mgr.findArticle("AAAB");
            Console.WriteLine(article != null ? article.ToString() : "pas d'article avec ce code");
        }
    }
}
