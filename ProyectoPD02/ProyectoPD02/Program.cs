using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{

    ///Se encarga de correr todo el programa
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 12-10-2022
    ///Versión: 1.0
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string opc = "";

            
            while(opc != "3")
            {
                Console.WriteLine("--------------------------------LOMITOS F.C----------------------------------------");
                Console.WriteLine("Bienvenido al programa de control de los centros de alto rendimiento de LOMITOS FC ");
                Console.WriteLine("Qué le gustaria ver? 1.Control de Centros de Alto rendimiento, 2.Control de alumnos, 3.Salir");
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


                    while (opc != "5")
                    {
                        Console.WriteLine("¿Qué le gustaria ver? 1.Alumnos, 2.Alumnos ordenados por Sucursal. 3.Pago correspondiente. 4.Pago con descuento 5.Salir");
                        opc = Console.ReadLine();

                        // Main representa al cliente
                        Dictionary<string, double> productos = new Dictionary<string, double>();

                        //Estos son los productos a usar
                        productos.Add("L-Mateo", 800);
                        productos.Add("M-Eduardo", 600);
                        productos.Add("A-Jorge", 500);
                        productos.Add("A-Luis", 500);
                        productos.Add("M-Manuel", 600);
                        productos.Add("L-Victor", 800);
                        productos.Add("A-Cesar", 500);
                        productos.Add("M-Sebastian", 600);
                        productos.Add("A-Esteban", 500);
                        productos.Add("L-Emilio", 800);

                        
                        if(opc == "1")
                        {
                            //Creamos el bridge
                            CAbstraccion bridge = new CAbstraccion(1, productos);
                            
                            bridge.MostrarTotales();
                            bridge.Listar();
                        }

                        if (opc == "2")
                        {
                            //Creamos el bridge
                            CAbstraccion bridge = new CAbstraccion(2, productos);

                            bridge.MostrarTotales();
                            bridge.Listar();
                        }

                        if (opc == "3")
                        {
                            //Creamos el bridge
                            CAbstraccion bridge = new CAbstraccion(3, productos);

                            bridge.Listar();
                            bridge.MostrarTotales();
                        }

                        if(opc == "4")
                        {
                            
                            //Creamos el bridge
                            CAbstraccion bridge = new CAbstraccion(4, productos);

                            bridge.Listar();
                            bridge.MostrarTotales();
                            
                            

                        }
                    }   
                }
            }






        }
    }
}
