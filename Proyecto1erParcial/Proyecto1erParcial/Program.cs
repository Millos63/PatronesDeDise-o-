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

                }


            }


        }
    }
}
