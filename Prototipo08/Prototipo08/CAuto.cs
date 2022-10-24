using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo08
{
    internal class CAuto : IPrototipo
    {
        private string modelo;
        private int costo;

        //propiedades get set 
        public string Modelo { get => modelo; set => modelo = value; }

        public CAuto(string pModelo, int pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", modelo, costo);
        }

        public object Clonar()
        {
            CAuto clon = new CAuto(modelo, costo);
            return clon;
        }


    }
}
