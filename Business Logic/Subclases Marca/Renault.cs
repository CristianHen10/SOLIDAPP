using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic
{
    public class Renault : Coche
    {
        public override string marcaCoche()
        {
            return "Renault";
        }

        public override int numAsientos()
        {
            return 7;
        }

        public override int precioMedioCoche()
        {
            return 18000;
        }
    }
}
