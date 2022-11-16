using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    internal class CLatex : IElementoPlastico
    {
        public void producir()
        {
            Console.WriteLine("Produciendo las piezas de latex para la protesis");
        }

        public string composicion()
        {
            return "Latex: Alta elasticidad, hidrofobicidad y resistencia electrica";
        }

        public int costo()
        {
            return 2000;
        }
    }
}
