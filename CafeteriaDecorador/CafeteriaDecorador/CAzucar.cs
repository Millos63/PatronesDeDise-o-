using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorador
{
    class CAzucar : IComponente
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        //Pasamos al objeto que va a ser decorado
        public CAzucar(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Azucar \r\n" + decoramosA.ToString(); 
        }

        //Metodos de la interfaz
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 1;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Se agrego Azucar";
        }



    }
}
