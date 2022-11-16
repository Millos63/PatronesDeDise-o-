using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CArduino 
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    class CArduino :IElementoElectrico
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a adquirir el elemento
        /// </summary>
        public void adquirir()
        {
            Console.WriteLine("Comprando los arduinos que se ocuparan para la protesis");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver la informacion del material
        /// </summary>
        public string informacion()
        {
            return "ARDUINO: Los arduinos nos ayudaran a conectarnos a otros dispositivos para interactuar con otro programa para la movilidad de la protesis";
        }
    }
}
