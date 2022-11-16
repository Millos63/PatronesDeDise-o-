using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    class CArduino:IElementoElectrico
    {
        public void adquirir()
        {
            Console.WriteLine("Comprando los arduinos que se ocuparan para la protesis");
        }
        public string informacion()
        {
            return "ARDUINO: Los arduinos nos ayudaran a conectarnos a otros dispositivos para interactuar con otro programa para la movilidad de la protesis";
        }
    }
}
