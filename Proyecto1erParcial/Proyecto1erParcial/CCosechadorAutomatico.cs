using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    ///Clase CCosechadorAutomatico
    ///Implementa IComponente
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 14-09-2022
    ///Versión: 1.0
    class CCosechadorAutomatico : IComponente   
    {
        //Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Este es el metodo constructor de la clase CCosechadorAutomatico
        /// </summary>
        /// <param name="pComponente"></param>
        public CCosechadorAutomatico(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo para sobreesvribir mi string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Cosechador automatico\r\n" + decoramosA.ToString();
        }


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de interfaz que implementamos
        /// </summary>
        /// <returns></returns>
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 100000;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de interfaz que implementamos
        /// </summary>
        /// <returns></returns>
        public string Funciona()
        {
            return decoramosA.Funciona() + "\n\rSe agrego un cosechador automatico, es muy caro, pero nos ahorraremos mucha mano de obra";
        }
    }
}
