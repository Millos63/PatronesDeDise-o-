using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            int edad = 0;
            int dinero = 0;
            int gamer = 0;
            int experiencia = 0;
            int sumatoria = 0;
            string leer;
            int leerDinero;
            int totalDinero = 0;
            IComputadora computadora; 

            while(opc != 5)
            {
                Console.WriteLine("Bienvenido a la seleccion de computadoras");
                Console.WriteLine("Elige las opciones segun te convenga: \n" +
                    "Edad: \n" +
                    "1. 10-15 \n" +
                    "2. 15-25 \n" +
                    "3. 25-35 \n" +
                    "4. 35 en adelante \n" +
                    "5. Salir \n");
                leer = Console.ReadLine();
                opc = Convert.ToInt32(leer);

                if (leer == "1")
                    edad = 3;
                else if (leer == "2")
                    edad = 7;
                else if (leer == "3")
                    edad = 11;
                else if (leer == "4")
                    edad = 15;

                //Console.WriteLine("Dinero: \n" +
                //    "1. 4000-8000 \n" +
                //    "2. 8000-15000 \n" +
                //    "3. 15000 - 22000 \n" +
                //    "4. 22000 - 25000 \n");
                Console.WriteLine("Cuál es su presupuesto?");
                leer = Console.ReadLine();
                leerDinero = Convert.ToInt32(leer);

                if (leerDinero <= 8000)
                {
                    dinero = 4;
                }
                else if (leerDinero <= 15000)
                {
                    dinero = 8;
                }
                else if (leerDinero <= 22000)
                    dinero = 13;
                else if (leerDinero <= 25000)
                    dinero = 18;

                Console.WriteLine("Gamer: \n" +
                    "1. Si \n" +
                    "2. No \n");
                leer = Console.ReadLine();

                if (leer == "1")
                    gamer = 16;
                else if (leer == "2")
                    gamer = 8;

                Console.WriteLine("Experiencia: \n" +
                    "1. Muy alta\n" +
                    "2. Alta \n" +
                    "3. Media\n" +
                    "4. Poca \n");
                leer = Console.ReadLine();

                if (leer == "1")
                    experiencia = 4;
                if (leer == "2")
                    experiencia = 8;
                if (leer == "3")
                    experiencia = 12;
                if (leer == "4")
                    experiencia = 16;



                sumatoria = edad + dinero + gamer + experiencia;


                //Obtenemos la computadora de la fabrica
                computadora = CCreador.MetodoFabrica(sumatoria);

                computadora.TipoComputadora();
                computadora.Procesador();
                computadora.TarjetaGrafica();
                computadora.MemoriaRam();
                computadora.Almacenamiento();




                //Edad, dinero,gamer,experiencia
                //sencilla = 4, normal = 8, gamer = 12, mac = 16
                //   < 28          <40          <52        <64  

                //Edad
                //10 - 15: 3
                //15 - 25: 7
                //25 - 35: 11
                //35....: 15

                //Dinero
                //4000 - 8000: 4
                //8000 - 15000: 8
                //15000 - 22000: 13
                //22000 - 25000: 18

                //Gamer
                // No: 8
                // Si: 16

                //Experiencia
                //Poca : 16
                //Media: 12
                //Alta: 8
                //Muy alta: 4


                //Obtenemos la instancia, se crea por primera vez
                CCaja uno = CCaja.ObtenInstancia();

                totalDinero = totalDinero + leerDinero;
                //Mandamos el dinero que se va a 
                uno.PonerDatos(totalDinero);
                Console.WriteLine(uno + "\n\n");
                Console.WriteLine("-----------------");

            }
            


        }
    }
}
