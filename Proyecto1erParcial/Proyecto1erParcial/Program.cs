using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class Program
    {

        static void Main(string[] args)
        {
            //variables
            string opc = "";

            //Interfaz de usuario
            while(opc != "4")
            {
                Console.WriteLine("---------ROJOS-----------\n\r" +
                "Bienvenido a la interfaz de usuario para la empresa ROJOS.\n\r" +
                "Cuál es la acción que le gustaria realizar?\n\r" +
                "1. Seleccionar carga. \n\r" +
                "2. Construir un nuevo invernadero \n\r" +
                "3. Pagar nomina \n\r" +
                "4. Salir");
                opc = Console.ReadLine();

                //1. Seleccionar carga
                if(opc == "1")
                {
                    //Variables
                    double xl = 0;
                    double l = 0;
                    double m = 0;
                    double s = 0;
                    double c = 0;
                    double color = 0;
                    string leer = "";
                    

                    Console.WriteLine("\n\r Bienvenido a la seleccionadora de ROJOS" +
                        "\n\r Vamos a empezar a seleccionar el jitomate. Cuántos jitomates tienes de:" +
                        "\n\rXL:");
                    leer = Console.ReadLine();
                    xl = Convert.ToDouble(leer);

                    Console.WriteLine("\n\rL:");
                    leer = Console.ReadLine();
                    l = Convert.ToDouble(leer);

                    Console.WriteLine("\n\rM:");
                    leer = Console.ReadLine();
                    m = Convert.ToDouble(leer);

                    Console.WriteLine("\n\rS:");
                    leer = Console.ReadLine();
                    s = Convert.ToDouble(leer);

                    Console.WriteLine("\n\rC:");
                    leer = Console.ReadLine();
                    c = Convert.ToDouble(leer);

                    Console.WriteLine("De qué color son los jitomates seleccionados?\n\r" +
                        "1. Verdes, 2. Inicio de color, 3. Naranjas, 4. Rojos ");
                    leer = Console.ReadLine();
                    color = Convert.ToInt32(leer);

                    //Verdes
                    if(color == 1)
                    {
                        
                    }

                    //Inicio de color
                    if(color == 2)
                    {

                    }

                    //Naranjas
                    if(color == 3)
                    {

                    }

                    //Rojos
                    if(color == 4)
                    {

                    }
                }


            }


        }
    }
}
