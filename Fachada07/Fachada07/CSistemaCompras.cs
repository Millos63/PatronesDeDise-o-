using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    //Esta clase representa uno de los subsistemas
    internal class CSistemaCompras
    {
        //Este metodo representa alguna operación que puede llevar a cabo el
        //subsistema, peude haber muchas mas y de mayor complejidad

        public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir numero de tarjeta");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;   
            }

        }
    }

    ////
    
    class CSubsistemaAlmacen
    {
        //Variables para guardar los productos del catalogo
        private int cubo3;
        private int cubo4;
        private int cubo5;
        private int piraminx;
        private int ghost;

        private int CB3;
        private int CB4;
        private int CB5;
        private int PX;
        private int GT;

        //private int cantidad; 

        //Metodo para inicializar los datos
        public void Inicializar(int cb3, int cb4, int cb5, int px, int gt)
        {
            CB3 = cb3;
            CB4 = cb4;
            CB5 = cb5;
            PX = px;
            GT = gt;
        }
           
        public CSubsistemaAlmacen()
        {
            cubo3 = CB3;
            cubo4 = CB4;
            cubo5 = CB5;
            piraminx = PX;
            ghost = GT;
        }

        public bool SacarAlmacen(int opc)
        {
            
            if(opc == 1)
            {
                //Para cubo3
                if (cubo3 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Producto listo para enviarse");
                    cubo3--;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Producto no disponible, espera a que haya existencias");
                    return false;
                }
                
            }
            else if (opc == 2)
            {
                //Para cubo4
                if (cubo4 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Producto listo para enviarse");
                    cubo4--;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Producto no disponible, espera a que haya existencias");
                    return false;
                }
            } 
            else if (opc == 3)
            {
                //Para cubo5
                if (cubo5 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Producto listo para enviarse");
                    cubo5--;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Producto no disponible, espera a que haya existencias");
                    return false;
                }

            }
            else if (opc == 4)
            {
                //Para piraminx
                if (piraminx > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Producto listo para enviarse");
                    piraminx--;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Producto no disponible, espera a que haya existencias");
                    return false;
                }
            }
            else if (opc == 5)
            {
                //Para piraminx
                if (ghost > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Producto listo para enviarse");
                    ghost--;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Producto no disponible, espera a que haya existencias");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    /////
    ///

    class CSubsistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envio va en camino");
        }
    }

    class CSubsistemaDevolucion
    {
        public void Devolucion()
        {

        }
    }

    //Catalogo de 5 productos
    //Cual producto y que cantidad

    //Dentro de fachada
    //Devolucion
    //Enviar de regreso
}
