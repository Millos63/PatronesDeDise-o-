using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    //Esta clase representa uno de los subsistemas
    internal class CSistemaCompras
    {
        //Este metodo representa alguna operación que puede llevar a cabo el
        //subsistema, peude haber muchas mas y de mayor complejidad

        public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir numero de tarjeta");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;   
            }

        }
    }

    ////
    
    class CSubsistemaAlmacen
    {
        private int cantidad; 

        public CSubsistemaAlmacen()
        {
            cantidad = 3;
        }

        public bool SacarAlmacen()
        {
            if(cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para enviarse");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Producto no disponible, espera a que haya existencias");
                return false;
            }
        }

        

    }

    /////
    ///

    class CSubsistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envio va en camino");
        }
    }

    //Catalogo de 5 productos
    //Cual producto y que cantidad
}
