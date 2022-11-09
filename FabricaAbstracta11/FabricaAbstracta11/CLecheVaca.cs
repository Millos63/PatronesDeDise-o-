using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal class CLecheVaca : IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Ordeñar vaca en la granja");
        }

        public string obtenDatos()
        {
            return "Leche de vaca, 250 ml";
        }
    }
}
