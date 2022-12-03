using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CSeleccionComputadora: IFuncionalidad
    {
        public void Funcionalidad()
        {
            //Variables que ayudaran al receptron a hacer su trabajo
            int d = 0;
            int r = 0;
            int g = 0;

            int opc = 0;

            int dinero = 0;
            int edad = 0;
            int experiencia = 0;
            int office = 0;
            int DS = 0;
            int desSof = 0;

            int respuesta = 0;


            string leer;
            int compra = 0;

            //Instancia de la interfaz
            IComputadora computadora;

            while (opc != 5)
            {

                Console.WriteLine("Bienvenido a la recomendacion de computadoras, donde se te recomendara una laptop según tus necesidades");
                
                Console.WriteLine("Cuál es tu presupuesto?");
                leer = Console.ReadLine();
                dinero = Convert.ToInt32(leer);

                if (dinero < 2000)
                    d = 0;
                else if (dinero > 2000 && dinero < 8000)
                    d = 1;
                else if (dinero < 15000)
                    d = 2;
                else if (dinero > 15000)
                    d = 3;
                
                    

                
                if (d == 0)
                {
                    ////-----aquí hay que ocupar el delegado----////
                    Console.WriteLine("No hay dinero suficiente");
                }

                if (d > 0)
                {
                    Console.WriteLine("\nCuál es tu edad? Selecciona un numero de las siguientes 3 opciones:" +
                    "\n1. 10 - 18" +
                    "\n2. 18-30" +
                    "\n3. 31...");
                    leer = Console.ReadLine();
                    edad = Convert.ToInt32(leer);
                    r += edad;


                    Console.WriteLine("\nCuál es tu experiencia:" +
                        "\n1. Poca" +
                        "\n2. Media" +
                        "\n3. Alta");
                    leer = Console.ReadLine();
                    experiencia = Convert.ToInt32(leer);
                    r += experiencia;

                    Console.WriteLine("\nTrabajas con paqueteria office:?" +
                        "\n1. No" +
                        "\n2. Si");
                    leer = Console.ReadLine();
                    office = Convert.ToInt32(leer);

                    if (office == 1)
                        r += 0;
                    if (office == 2)
                        r += 1;

                    Console.WriteLine("\nOcuparas la computadora para diseño?:" +
                        "\n1. No" +
                        "\n2. Si");
                    leer = Console.ReadLine();
                    DS = Convert.ToInt32(leer);

                    if (DS == 1)
                        r += 0;
                    else if (DS == 2)
                        r += 6;

                    Console.WriteLine("\nOcuparas la computadora para desarrollo de software?" +
                        "\n1. No" +
                        "\n2. Si");
                    leer = Console.ReadLine();
                    desSof = Convert.ToInt32(leer);
                    if (desSof == 1)
                        r += 0;
                   else if (desSof == 2)
                        r += 6;


                    if (d == 3)
                    {
                        Console.WriteLine("\nEres gamer: " +
                            "\n1. No" +
                            "\n2. Si");
                        leer = Console.ReadLine();
                        g = Convert.ToInt32(leer);
                    }

                    if(r < 7 && g == 1 && d > 0 )
                    {
                        respuesta = 1;
                    }
                    else if (r < 11 && g == 1 && d > 1)
                    {
                        respuesta = 2;
                    }
                    else if (r < 20 && g == 1 && d == 3)
                    {
                        respuesta = 3;
                    }
                    else if (r >0 && g == 2 && d == 3)
                    {
                        respuesta = 4;
                    }


                }
           
                


                //Obtenemos la computadora de la fabrica
                computadora = CCreador.MetodoFabrica(respuesta);
                computadora.TipoComputadora();
                computadora.Procesador();
                computadora.TarjetaGrafica();
                computadora.MemoriaRam();
                computadora.Almacenamiento();

                Console.WriteLine("\nDesea comprar esa computadora?" +
                    "\n1. No" +
                    "\n2. Si");
                leer = Console.ReadLine();
                compra = Convert.ToInt32(leer);

                if(compra == 2)
                {
                    //Este es singleton
                    //Obtenemos la instancia, se crea por primera vez
                    CCaja uno = CCaja.ObtenInstancia();

                    //totalDinero = totalDinero + leerDinero;
                    //Mandamos el dinero que se va a 
                    Console.ForegroundColor = ConsoleColor.Green;
                    dinero += dinero;
                    uno.PonerDatos(dinero);
                    Console.WriteLine(uno + "\n\n");
                    Console.WriteLine("-----------------");
                    Console.ForegroundColor= ConsoleColor.White;
                }
            }
        }
    }
}
