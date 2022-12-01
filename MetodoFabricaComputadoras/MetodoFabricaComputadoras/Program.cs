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

            IFuncionalidad miFuncionalidad = new CSeleccionComputadora();

            miFuncionalidad = new CSeleccionComputadora();

            miFuncionalidad.Funcionalidad();



        }
    }
}
