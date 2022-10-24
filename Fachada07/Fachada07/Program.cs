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
            string opc = "";
            
            while (opc != "3")
            {
                Console.WriteLine("------------------Tienda de rubiks The Maiosha-------------------");
                Console.WriteLine("Qué deseas hacer? 1. Comprar un producto, 2. Devolver un producto, 3. Salir");
                opc = Console.ReadLine();

                if (opc == "1")
                {
                    //Hacemos uso de los subsistemas a traves de la interfaz
                    //sencilla de la fachada
                    fachada.Compra();
                }
                
                if (opc == "2")
                {
                    fachada.Devolucion();
                }
            }
            

        }
    }
}
