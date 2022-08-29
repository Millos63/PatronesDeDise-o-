using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CSuspension : IComponente
    {
        //Variable de referencia a quien decoramos
        private IComponente decoramosA;

        //Pasamos al objeto que va a ser decorado
        public CSuspension(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto desempeño \r\n" + decoramosA.ToString();
        }

        //Metodos de la interfaz
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 63850;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando suspension";
        }
    }
}
