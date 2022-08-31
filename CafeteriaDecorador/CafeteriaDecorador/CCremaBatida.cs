using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorador
{
    class CCremaBatida : IComponente
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        //Pasamos al objeto que va a ser decorado
        public CCremaBatida(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Crema Batida \r\n" + decoramosA.ToString();
        }

        //Metodos de la interfaz
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 10;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Se agrego Crema Batida";
        }
    }
}
