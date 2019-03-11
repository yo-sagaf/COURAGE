using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            getList();
		}
        public void getList()
        {
            listeArticles.ItemsSource = new Articles[]
            {
                new Articles {Nom = "Bananes", Nombre = 42 },
                new Articles {Nom = "Smartphones", Nombre = 24},
                new Articles {Nom = "Gateaux", Nombre = 157},
                new Articles {Nom = "Tabourets", Nombre = 38},
                new Articles {Nom = "Bouteilles", Nombre = 15},
                new Articles {Nom = "Ballons", Nombre = 73},
                new Articles {Nom = "Glaces", Nombre = 11},
                new Articles {Nom = "Cannes", Nombre = 12},
                new Articles {Nom = "Grilles-pain", Nombre = 47},
                new Articles {Nom = "Respirateurs", Nombre = 4},
                new Articles {Nom = "Vestes", Nombre = 8},
                new Articles {Nom = "Adhésifs", Nombre = 67},
                new Articles {Nom = "Maillots de bain", Nombre = 16},
                new Articles {Nom = "Menottes", Nombre = 135},
                new Articles {Nom = "Fouets", Nombre = 124},
            };
        }
	}

    class Articles
    {
        public string Nom { get; set; }
        public int Nombre { get; set; }
    }
}
