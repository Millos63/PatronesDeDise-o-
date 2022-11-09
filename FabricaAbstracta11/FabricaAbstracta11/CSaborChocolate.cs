using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal class CSaborChocolate : IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }

        public string informacion()
        {
            return "Sabor a chocolate";
        }
    }
}
