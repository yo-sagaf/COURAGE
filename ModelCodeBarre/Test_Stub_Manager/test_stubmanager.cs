using System;
using System.Collections.Generic;
using System.Text;
using ModelCodeBarre;


namespace Test_Stub_Manager
{
    class test_stubmanager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StubDataManager stub1 = new StubDataManager();
            List<Article> affichage
              = new List<Article>();

            affichage = stub1.getArticles();
            foreach (Article articleSearch in affichage)
            {
                Console.WriteLine($"Article :{articleSearch.Nom}");

            }

            Article tt = new Article("DDDD", "ballon");

            bool isAdd = stub1.addArticle(tt);

            foreach (Article articleSearch in affichage)
            {
                Console.WriteLine($"Article :{articleSearch.Nom}");

            }
            Console.WriteLine($" Booleen {isAdd}");
            Article isFind = stub1.findArticle("AAAA");
            Console.WriteLine($"Nom article trouvé :  {isFind.Nom}");

            


        }
    }
}
