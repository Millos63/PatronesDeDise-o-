using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    class CAcero : IElementoMetal
    {
        public void fabricar()
        {
            Console.WriteLine("Fabricando el acero que se ocupara");
        }
        public string obtenDatos()
        {
            return "ACERO: Material rigido, resistencia a la corrosion y elevada resistencia mecanica";
        }

        public int costo()
        {
            return 4000;
        }
    }
}
