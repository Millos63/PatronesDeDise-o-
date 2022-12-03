using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string r = "";

            //Para la recomendacion de computadora y seleccion.
            IFuncionalidad miFuncionalidad = new CSeleccionComputadora();

            miFuncionalidad = new CSeleccionComputadora();

            miFuncionalidad.Funcionalidad();

            //Para la creacion de la computadora
            IFuncionalidad miFuncionalidad2 = new CCreacionComputadora();

            miFuncionalidad2 = new CCreacionComputadora();

            miFuncionalidad2.Funcionalidad();
            






        }
    }
}
