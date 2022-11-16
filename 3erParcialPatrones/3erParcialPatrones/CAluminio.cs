using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    class CAluminio : IElementoMetal
    {
        public void fabricar()
        {
            Console.WriteLine("Fabricando el aluminio que se ocupara");
        }
        public string obtenDatos()
        {
            return "ALUMINIO: Ligera, resistente y de larga duracion. Tiene una excelente conductividad de la electricidad";
        }
        public int costo()
        {
            return 5000;
        }
    }
}
