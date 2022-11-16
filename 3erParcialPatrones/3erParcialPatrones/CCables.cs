using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CCables
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    class CCables : IElementoElectrico 
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a adquirir el elemento
        /// </summary>
        public void adquirir()
        {
            Console.WriteLine("Comprando los cables que se ocuparan para la protesis");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver la informacion del material
        /// </summary>
        public string informacion()
        {
            return "CABLES: Los cables que se ocuparan son diseñados especialmente para la protesis, resistentes y de muy buena calidad";
        }
    }
}
