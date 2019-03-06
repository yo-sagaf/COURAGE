using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCodeBarre
{
    class multimedia:Article
    {
        public multimedia(String codeBarre, String nom,DateTime garantie):base(codeBarre, nom)

        {
            Garantie = garantie;

        }
        public DateTime Garantie { get; set; }
        public bool mode_paie { get; set; }

    }
}
