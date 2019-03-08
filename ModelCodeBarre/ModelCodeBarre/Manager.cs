using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCodeBarre
{
    public class Manager
    {
        public IDataManager DataMgr { get; private set; }
        public Manager (IDataManager dataManager)
        {
            DataMgr = dataManager;
        }

        public Article findArticle(String codeBarre)
        {
            return DataMgr.findArticle(codeBarre);
        }
        public List<Article> getArticles()
        {
            return DataMgr.getArticles();
        }

        public bool addArticle(Article article)
        {
            return DataMgr.addArticle(article);

        }
    }
}
