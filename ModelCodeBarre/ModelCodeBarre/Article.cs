using System;

namespace ModelCodeBarre
{
    public class Article
    {
        public Article(String codeBarre, String nom)
        {
            CodeBarre = codeBarre;
            Nom = nom;
        }

        public String Type {get;set;}
        public String Nom {get;set;}
        public float Prix {get;set;}
        public String Marque {get;set;}
        public String CodeBarre {get;set;}
        // public DateTime DatePeremption {get; set;}

            private int qté;
        public int Qté
        {

            get
            {
                return qté;
            }

            set
            {
                qté = value;
                if (qté < 0)
                    qté = 0;
            }

        }

        public override string ToString()
        {
            return string.Format($"N° = {CodeBarre} , Reference : {Nom}, Prix : {Prix}");
        }


    }
}
