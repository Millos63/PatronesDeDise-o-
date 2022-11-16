using System;

namespace _3erParcialPatrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opc = "";
            string tipo = "";
            

            
            Console.WriteLine("----------------NEURO-EXO----------------" +
                "\n Bienvenido a la fabrica de Neuro-Exo, donde se crean protesis." +
                "\n Qué tipo de protesis le gustaria crear?" +
                "\n 1. Estatica" +
                "\n 2. Dinamica");
            tipo = Console.ReadLine();
            
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
                if (opc == "1")
                {
                    miPlastico.producir();
                    Console.WriteLine("Fabricando la protesis hecha de:{0} " +
                        "\nCosto Final:{1}", miPlastico.composicion(), miPlastico.costo());
                }
                if (opc == "2")
                {
                    miMetal.fabricar();
                    Console.WriteLine("Fabricando la protesis hecha de: {0} " +
                        "\nCosto Final:{1}", miMetal.obtenDatos(), miMetal.costo());
                }
                Console.WriteLine("\n\n\n\n\n");
            }


            ///Fabrica dinamica
            if (tipo == "2")
            {
                int elemento = 1;
                Console.WriteLine("Estas protesis son protesis mas avanzadas, y ocupan de cada uno de los elementos de la fabrica para su producción");

                IFabrica miFabrica = new CFabricaDinamica(elemento);
                miFabrica.crearProtesis();
                IElementoPlastico miPlastico = miFabrica.ObtenElementoPlastico;
                


                elemento = 1; 
                if(elemento == 1)
                {
                    miPlastico.producir();
                    Console.WriteLine("Se ocupara el plastico con ciertas propiedades:{0} ", miPlastico.composicion());
                }


                int elemento2 = 2;
                IFabrica miFabrica2 = new CFabricaDinamica(elemento2);
                //IElementoPlastico miPlastico2 = miFabrica2.ObtenElementoPlastico;
                IElementoMetal miMetal = miFabrica2.ObtenElementoMetal;
                miFabrica2.crearProtesis();
                miMetal.fabricar();
                if (elemento2 == 2)
                {
                    miMetal.fabricar();
                    Console.WriteLine("Se ocupara el metal con ciertas propiedades:{0}", miMetal.obtenDatos());
                }


                IElementoElectrico miElectrico = miFabrica.ObtenElementoElectrico;
                
            }


            

            


        }
    }
}
