using System;

namespace ProyectoPD02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opc = "";

            
            while(opc != "3")
            {
                Console.WriteLine("--------------------------------LOMITOS F.C----------------------------------------");
                Console.WriteLine("Bienvenido al programa de control de los centros de alto rendimiento de LOMITOS FC ");
                Console.WriteLine("Qué le gustaria ver? 1.Control de Centros de Alto rendimiento, 2.Control de pagos, 3.Salir");
                opc = Console.ReadLine();
                //Componente
                //1.Control de centros de alto rendimiento
                if (opc == "1")
                {
                    
                    IComponente<string> arbol = new CCompuesto<string>("Control Centros de Rendimiento");
                    IComponente<string> trabajo = arbol;

                    string opcion = "";
                    string dato = "";

                    
                    while (opcion != "6")
                    {
                        Console.WriteLine("Estoy en {0}", trabajo.Nombre);
                        Console.WriteLine("1. Adicionar centro de rendimiento, 2.Adicionar jugador 3. Borrar, 4.Buscar, 5.Mostrar, 6.Salir");
                        opcion = Console.ReadLine();
                        Console.WriteLine("----------------");

                        if (opcion == "1")
                        {
                            Console.WriteLine("Dime la ubicacion del centro de rendimiento: ");
                            dato = Console.ReadLine();

                            IComponente<string> c = new CCompuesto<string>(dato);
                            trabajo.Adicionar(c);
                            trabajo = c;
                        }
                        if (opcion == "2")
                        {
                            Console.WriteLine("Dime el nombre del jugador ");
                            dato = Console.ReadLine();
                            trabajo.Adicionar(new CCompuesto<string>(dato));
                        }

                        if (opcion == "3")
                        {
                            Console.WriteLine("Dame el elemento a borrar: ");
                            dato = Console.ReadLine();

                            trabajo = trabajo.Borrar(dato);
                        }

                        if (opcion == "4")
                        {
                            Console.WriteLine("Dame el elemento a encontrar: ");
                            dato = Console.ReadLine();
                            trabajo = arbol.Buscar(dato);
                        }
                        if (opcion == "5")
                        {
                            Console.WriteLine(arbol.Mostrar(0));
                        }

                        
                    }
                }

                //Bridge
                //Control de pagos
                if(opc == "2")
                {

                }
            }






        }
    }
}
