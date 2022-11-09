using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal class CLecheCoco : IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }


        public string obtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }
    }
}
