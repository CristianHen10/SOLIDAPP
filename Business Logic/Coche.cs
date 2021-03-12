using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic
{
    public abstract class Coche
    {
        public string Placa { get; set; }
        public int Modelo { get; set; }
        public string Color { get; set; }

        public abstract string marcaCoche();
        public abstract int precioMedioCoche();
        public abstract int numAsientos();

    }
}
