using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este es el cliente
            int resultado = 0;

            //usamos la interfaz que el cliente conoce con una clase que conoce
            ITarget calcu = new CCalcu();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado de la suma es {0}", resultado);
            resultado = calcu.Resta(4, 3);
            Console.WriteLine("El resultado de la resta es {0}", resultado);
            resultado = calcu.Multiplicar(4, 3);
            Console.WriteLine("El resultado de la multiplicacion es {0}", resultado);
            resultado = calcu.Dividir(50, 10);
            Console.WriteLine("El resultado de la division es {0}", resultado);

            

            Console.WriteLine("---Calculadora arrays---");

            //Hacemos uso del adaptador

            calcu = new CAdaptador();

            //Usamos el adaptador para hacer la operacion
            resultado = calcu.Sumar(5, 6);

            Console.WriteLine("El resultado de la suma es {0}", resultado);

            ////PARA LA RESTA
            Console.WriteLine("---------Resta---------");
            resultado = calcu.Resta(100, 90);
            Console.WriteLine("El resultado de la resta es {0}", resultado);


            ////PARA LA MULTIPLICLACION
            Console.WriteLine("---------Multiplicacion---------");
            resultado = calcu.Multiplicar(30, 10);
            Console.WriteLine("El resultado de la multiplicacion es {0}", resultado);

            ////PARA LA DIVISION
            Console.WriteLine("---------Division---------");
            resultado = calcu.Dividir(50, 25);
            Console.WriteLine("El resultado de la Division es {0}", resultado);

        }
    }
}
