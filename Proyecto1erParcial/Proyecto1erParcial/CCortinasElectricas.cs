using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class CCortinasElectricas : IComponente
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;
        private double metros;

        //Pasamos al objeto que va a ser decorado
        public CCortinasElectricas(IComponente pComponente, double pMetros)
        {
            decoramosA = pComponente;
            metros = pMetros;
        }

        public override string ToString()
        {
            return "Cortinas electricas  \r\n" + decoramosA.ToString();
        }

        //Metodos de la interfaz
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + (8 * metros);
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + "\n\rSe instalaron Cortinas electricas para abrir y cerrar automaticamente el invernadero";
        }
    }
}
