using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal class CVainillaNatural : IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("Se extrae de las vainas");
        }

        public string informacion()
        {
            return "Extracto natural de vainilla";
        }
    }

}
