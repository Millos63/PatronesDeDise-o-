using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    class CCables: IElementoElectrico 
    {
        public void adquirir()
        {
            Console.WriteLine("Comprando los cables que se ocuparan para la protesis");
        }
        public string informacion()
        {
            return "CABLES: Los cables que se ocuparan son diseñados especialmente para la protesis, resistentes y de muy buena calidad";
        }
    }
}
