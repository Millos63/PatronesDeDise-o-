using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CLaptop:IComponente
    {
        private string nombre;
        private double costo;

        
        public CLaptop(string pNombre, double pCosto)
        {
            nombre = pNombre;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Tipo: {0} \r\n", nombre)
        }

        //Estos son los metodos implementados de IComponente
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Se armo una PC";
        }

    }
}
