using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    internal class CSilicona : IElementoPlastico
    {
        public void producir()
        {
            Console.WriteLine("Se esta produciendo las piezas de silicon para la protesis");

        }

        public string composicion()
        {
            return "SILICONA: Elasticidad y flexibilidad, aislante electrico, es resistente a la deformacion por compresion";
        }

        public int costo()
        {
            return 2800;
        }

    }
}
