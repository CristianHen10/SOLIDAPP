using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic.Clases_BBDD
{
    interface Conexion
    {
        Dato getDatos();
        void setDatos();
    }
}
