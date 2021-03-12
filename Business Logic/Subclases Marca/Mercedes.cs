using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic.Clases_Marcas
{
    public class Mercedes : Coche
    {
        public override string marcaCoche()
        {
            return "Mercedes Benz";
        }

        public override int numAsientos()
        {
            return 4;
        }

        public override int precioMedioCoche()
        {
            return 27000;
        }


    }
}
