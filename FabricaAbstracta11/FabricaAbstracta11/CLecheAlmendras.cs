using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal class CLecheAlmendras : IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Procesar las almendras");
        }

        public string obtenDatos()
        {
            return "Leche organica de almendra, 250ml";
        }
    }
}
