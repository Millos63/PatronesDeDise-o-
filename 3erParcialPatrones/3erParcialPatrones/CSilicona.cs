using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    internal class CSilicona : IElementoPlastico
    {
        public void producir()
        {
            Console.WriteLine("Se esta produciendo el silicon para la protesis");

        }

        public string composicion()
        {
            Console.WriteLine("");
        }
    
    }
}
