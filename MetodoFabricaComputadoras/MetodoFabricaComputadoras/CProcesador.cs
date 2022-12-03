using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CProcesador:IComponente
    {
        private IComponente decoramosA;
        private int seleccion;
        private int costo = 0;

        //Pasamos al objeto que va a ser decorado
        public CProcesador(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return string.Format("{0}\r\n", seleccion + decoramosA.ToString());
        }

        public int Seleccion()
        {
            if (seleccion == 0)
            {
                return costo = 10;
            }
        }

        //Metodos de la interfaz
        public double Costo()
        {
            ///Hacer una sobrecarga de constructor, para poder hacer un objeto que le pases un parametro de int o etc.
            CProcesador miProce = new CProcesador();
            return decoramosA.Costo() + costo; 
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Se agrego procesador";
        }


    }
}
