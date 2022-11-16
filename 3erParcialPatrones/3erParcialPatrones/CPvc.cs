using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    internal class CPvc : IElementoPlastico
    {
        public void producir()
        {
            Console.WriteLine("Produciendo las piezas de PVC para la protesis");
        }

        public string composicion()
        {
            return "PVC: Tiene buen aislamiento acustico y térmico, vida util larga"; 
        }
        public int costo()
        {
            return 2500;
        }

    }
}
