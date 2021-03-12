using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic.Clases_Tipos_Aves.Subclases_Aves
{
    public class Pinguino : IAve, IAveNadadora
    {
        public string Comer()
        {
            return "Los Pingüinos son carnivoros y su ingesta de carne es alta.";
        }

        public string Nadar()
        {
            return "Los Pingüinos son capaces de nadar a una velocidad de 19 Km/h";
        }
    }
}
