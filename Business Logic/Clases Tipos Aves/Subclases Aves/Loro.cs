using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic.Clases_Tipos_Aves.Subclases_Aves
{
    public class Loro : IAve, IAveVoladora
    {
        public string Comer()
        {
            return "El Loro come diferentes tipos de semillas";
        }

        public string Volar()
        {
            return "El Loro puede volar pero no muy alto";
        }
    }
}
