using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    class CFibraDeCarbono : IElementoMetal
    {
        public void fabricar()
        {
            Console.WriteLine("Fabricando la fibra de carbono que se ocupara");
        }
        public string obtenDatos()
        {
            return "Fibra de carbono: Muy resistente, baja conductividad termica, excelente conductor de electricidad, material liviano";
        }
        public int costo()
        {
            return 6000;
        }
    }
}
