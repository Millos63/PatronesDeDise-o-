using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class CInverHolandes : IComponente
    {
        private string nombre;
        private double costo;

        public CInverHolandes(string pNombre, double pCosto)
        {
            nombre = pNombre;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Invernadero: {0} \n\r", nombre);
        }

        //Estos son los metodos implementados por IComponente\
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Se construyo un invernadero holandes";
        }
    }
}
