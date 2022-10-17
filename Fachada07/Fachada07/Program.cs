using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Necesario para usar los subsistemas
using Subsistemas;


namespace Fachada07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos la instancia de la fachada
            CFachada fachada = new CFachada();

            //Hacemos uso de los subsistemas a traves de la interfaz
            //sencilla de la fachada
            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------");

            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------");

            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------");

            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------");

        }
    }
}
