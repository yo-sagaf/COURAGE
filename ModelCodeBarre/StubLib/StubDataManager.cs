using ModelCodeBarre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StubLib
{
    public class StubDataManager : IDataManager
    {
        public StubDataManager()
        {   
            Article article1 = new Article("AAAA","brosse à dent");
            Article article2 = new Article("BBBB","maillot");
            Article article3 = new Article("CCCC","coca");

            Inventaire.Add(article1);
            Inventaire.Add(article2);
            Inventaire.Add(article3);
        }

        public List<Article> getArticles()
        {
            return Inventaire;
        }

        public bool addArticle(Article article)
        {
            int nbrArticle = Inventaire.Count;
            Inventaire.Add(article);
            int nbrArticleNew = Inventaire.Count;
            if(nbrArticleNew == (nbrArticle + 1))
            {
                return true;

            }else {
                return false;
            }
        }
        public Article findArticle(String codeBarre) {
            //Article articleTrouvé = new Article("","");
            //foreach (Article articleSearch in Inventaire) {
            //    if(articleSearch.CodeBarre == codeBarre)
            //    {
            //        articleTrouvé = articleSearch;
            //    } else
            //    {
            //        articleTrouvé = null;
            //    }
                         
            //}
            return Inventaire.SingleOrDefault(art => art.CodeBarre == codeBarre);
            //return articleTrouvé;

        }

        List<Article> Inventaire { get; set; }
              = new List<Article>();


        public override string ToString()
        {
            string resultat = "";
            foreach (Article article in Inventaire) // pour chaque Nounours dans les nounours 
            {
                resultat += $"{article.Nom} ";
            }
            return resultat;
        }


    }


       
}
