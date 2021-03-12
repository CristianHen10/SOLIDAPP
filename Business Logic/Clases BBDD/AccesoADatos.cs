using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDAPP.Business_Logic.Clases_BBDD
{
    public class AccesoADatos
    {
        private Conexion conexion;

        AccesoADatos(Conexion conexion)
        {
            this.conexion = conexion;
        }
        public Dato getDatos()
        {
            return conexion.getDatos();
        }
    }
}
