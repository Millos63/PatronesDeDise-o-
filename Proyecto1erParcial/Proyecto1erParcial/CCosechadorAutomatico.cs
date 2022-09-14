using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class CCosechadorAutomatico : IComponente   
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        //Pasamos al objeto que va a ser decorado
        public CCosechadorAutomatico(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Cosechador automatico\r\n" + decoramosA.ToString();
        }

        //Metodos de la interfaz
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 100000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + "\n\rSe agrego un cosechador automatico, es muy caro, pero nos ahorraremos mucha mano de obra";
        }
    }
}
