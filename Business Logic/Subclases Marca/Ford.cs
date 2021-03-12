using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic.Clases_Marcas
{
    public class Ford : Coche
    {
        public override string marcaCoche()
        {
            return "Ford";
        }

        public override int numAsientos()
        {
            return 3;
        }

        public override int precioMedioCoche()
        {
            return 23000;
        }
    }
}
