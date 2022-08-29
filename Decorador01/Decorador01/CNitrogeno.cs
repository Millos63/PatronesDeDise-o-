using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CNitrogeno : IComponente
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        //Pasamos al objeto que va a ser decorado
        public CNitrogeno(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Sistema de Nitrogeno \r\n" + decoramosA.ToString();
        }
        //Metodos de la interfaz
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
