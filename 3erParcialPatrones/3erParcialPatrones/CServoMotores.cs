using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CServoMotores
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    class CServoMotores : IElementoElectrico
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a adquirir el elemento
        /// </summary>
        public void adquirir()
        {
            Console.WriteLine("Comprando los servomotores para la protesis");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver la informacion del material
        /// </summary>
        public string informacion()
        {
            return " SERVO-MOTORES: Los Servo-Motores nos serviran para darle todo el movimiento a la protesis, ocuparemos los de la mejor calidad";
        }
    }
}
