using System;

namespace _3erParcialPatrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables para el buen funcionamiento
            string opc = "";
            string tipo = "";
            
            
            // Pequeña interfaz de interaccion con el usuario  
            Console.WriteLine("----------------NEURO-EXO----------------" +
            "\n Bienvenido a la fabrica de Neuro-Exo, donde se crean protesis." +
            "\n Qué tipo de protesis le gustaria crear?" +
            "\n 1. Estatica" +
            "\n 2. Dinamica");

            tipo = Console.ReadLine();
            
            // tipo = 1. Protesis Estetica
            if (tipo == "1")
            {
                Console.WriteLine("Te gustaria crear tu protesis estatica con partes: " +
                "\n 1. Plasticas" +
                "\n 2. Metalicas");

                opc = Console.ReadLine();
               
                IFabrica miFabrica = new CFabricaEstatica(opc);
                miFabrica.crearProtesis();
                
                IElementoPlastico miPlastico = miFabrica.ObtenElementoPlastico;
                IElementoMetal miMetal = miFabrica.ObtenElementoMetal;
                
                // opc = 1. Plasticas.
                if (opc == "1")
                {
                    miPlastico.producir();
                    Console.WriteLine("Fabricando la protesis hecha de:{0} " +
                    "\nCosto Final:{1}", miPlastico.composicion(), miPlastico.costo());
                }
                // opc = 2. Metalicas.
                if (opc == "2")
                {
                    miMetal.fabricar();
                    Console.WriteLine("Fabricando la protesis hecha de: {0} " +
                    "\nCosto Final:{1}", miMetal.obtenDatos(), miMetal.costo());
                }
                Console.WriteLine("\n\n\n\n\n");
            }


            
            // tipo = 2. Protesis dinamica
            if (tipo == "2")
            {
                //Variable para sumar los costos
                int costoFinal = 0;

                Console.WriteLine("\nPROTESIS DINAMICAS" +
                "\nEstas protesis son protesis mas avanzadas, y ocupan de un elemento plastico y uno metalico, así como de todos los elementos electricos." +
                "Presione 1 para continuar\n");
                Console.ReadLine();

                IFabrica miFabrica = new CFabricaDinamica();
                miFabrica.crearProtesis();
                IElementoPlastico miPlastico = miFabrica.ObtenElementoPlastico;
                IElementoMetal miMetal = miFabrica.ObtenElementoMetal;
                IElementoElectrico miElectrico = miFabrica.ObtenElementoElectrico;
                IElementoElectrico miElectrico2 = miFabrica.ObtenElementoElectrico2;
                IElementoElectrico miElectrico3 = miFabrica.ObtenElementoElectrico3;

                Console.ForegroundColor = ConsoleColor.Yellow;
                miPlastico.producir();
                miMetal.fabricar();
                miElectrico.adquirir();
                miElectrico2.adquirir();
                miElectrico3.adquirir();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Para la protesis se han seleccionado los siguientes materiales, se enlistaran algunas de sus propiedades.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0} ", miPlastico.composicion());
                Console.WriteLine("{0}", miMetal.obtenDatos());
                Console.WriteLine("{0}", miElectrico.informacion());
                Console.WriteLine("{0}", miElectrico2.informacion());
                Console.WriteLine("{0}", miElectrico3.informacion());

                costoFinal = miPlastico.costo();
                costoFinal += miMetal.costo();

                //Se suma esta cantidad, ya que se suma el valor de los componentes electricos, y la mano de obra ya que es mas cara la producción de estas.
                costoFinal += 100000;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Costo final: {0}", costoFinal);

                Console.ForegroundColor = ConsoleColor.White;
            }


            

            


        }
    }
}
