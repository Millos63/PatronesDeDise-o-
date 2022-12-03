using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CCreacionComputadora : IFuncionalidad
    {
        public void Funcionalidad()
        {
            string opc = "";
            string opc2 = "";
            int computadora = 0;
            int complemento = 0;

            //Variable IComponente para guaradar el tipo de computadora seleccionado
            IComponente miCompu = new CLaptop("Laptop", 0);

        }
    }
}
