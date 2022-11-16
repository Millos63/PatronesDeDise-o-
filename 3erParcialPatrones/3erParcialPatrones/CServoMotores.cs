using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    class CServoMotores : IElementoElectrico
    {
        public void adquirir()
        {
            Console.WriteLine("Comprando los servomotores para la protesis");
        }

        public string informacion()
        {
            return " SERVO-MOTORES: Los Servo-Motores nos serviran para darle todo el movimiento a la protesis, ocuparemos los de la mejor calidad";
        }
    }
}
