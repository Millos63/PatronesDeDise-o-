using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class CInverTierra : IComponente
    {
        private string nombre;
        private double costo;

        public CInverTierra(string pNombre, double pCosto)
        {
            nombre = pNombre;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Invernadero: {0} \r\n", nombre);
        }

        //Estos son lo metodos implementados de IComponente
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Se construyo un invernadero de tierra";
        }
    }
}
