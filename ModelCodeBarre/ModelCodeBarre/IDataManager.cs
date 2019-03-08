using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCodeBarre
{
    public interface IDataManager
    {
        Article findArticle(String codeBarre);
        List<Article> getArticles();
        bool addArticle(Article article);


    }
}
