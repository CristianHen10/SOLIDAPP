using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic
{
    public class Audi : Coche
    {
        public override string marcaCoche()
        {
            return "Audi";
        }

        public override int numAsientos()
        {
            return 2;
        }

        public override int precioMedioCoche()
        {
            return 25000;
        }
    }
}
