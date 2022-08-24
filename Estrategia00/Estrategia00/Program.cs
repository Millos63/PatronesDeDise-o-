using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia00
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";

            //Nuestra variable que referencia al algoritmo
            //Instanciamos con un default para permitir compilacion correcta
            IOperacion miOperacion = new CSuma();

            while (opcion != "7")
            {
                Console.WriteLine("1.- Suma, 2.- Resta, 3.- Multi, 4.-Div 5.-potencia 6.-Modulo 7.-salir");

                opcion = Console.ReadLine();
                if (opcion == "7")
                    break;

                Console.WriteLine("Dame el valo de a");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Dame el valo de b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);


                //aqui seleccionamos el algoritmo deacuerdo a la necesidad

                if (opcion == "1")
                    miOperacion = new CSuma();

                if (opcion == "2")
                    miOperacion = new CResta();

                if (opcion == "3")
                    miOperacion = new CMulti();

                if (opcion == "4")
                    miOperacion = new CDiv();

                if (opcion == "5")
                    miOperacion = new CPotencia();

                if (opcion == "6")
                    miOperacion = new CModulo();

                r = miOperacion.operacion(x, y);

                Console.WriteLine("El resultado es {0}", r);
            }
        }
    }
}
