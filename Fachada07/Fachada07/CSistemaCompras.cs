using System;

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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
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

        //private int cantidad; 

        //Metodo para inicializar los datos
        public void Inicializar(int cb3, int cb4, int cb5, int px, int gt)
        {
            cubo3 = cb3;
            cubo4 = cb4;
            cubo5 = cb5;
            piraminx = px;
            ghost = gt;
        }

        public CSubsistemaAlmacen()
        {


        }

        public bool SacarAlmacen(int opc)
        {

            if (opc == 1)
            {
                //Para cubo3
                if (cubo3 > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Se ha enviado un cubo 3x3");
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
                    Console.WriteLine("Se ha enviado un cubo 4x4");
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
                    Console.WriteLine("Se ha enviado un cubo 5*5");
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
                    Console.WriteLine("Se ha enviado un cubo piraminx");
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
                    Console.WriteLine("Se ha enviado un cubo ghost");
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
            else if (opc == 6)
            {
                Console.WriteLine("Programa terminado");
                return false;
            }
            else
            {
                return false;
            }
        }


        public bool RegresarAlmacen(int opc)
        {
            if (opc == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Devolucion en camino");
                cubo3++;
                return true;


            }
            else if (opc == 2)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Devolucion en camino");
                cubo4++;
                return true;
            }
            else if (opc == 3)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Devolucion en camino");
                cubo5++;
                return true;


            }
            else if (opc == 4)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Devolucion en camino");
                piraminx++;
                return true;

            }
            else if (opc == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Devolucion en camino");
                ghost++;
                return true;
            }
            else if (opc == 6)
            {
                Console.WriteLine("Programa terminado");
                return false;
            }
            else
            {
                return false;
            }
        }

        public void cantidadProductos()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", cubo3, cubo4, cubo5, piraminx, ghost);

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

    }
    
    class CSubsistemaEnvioDev
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La devolucion va en camino");

        }
    }

    //Catalogo de 5 productos
    //Cual producto y que cantidad

    //Dentro de fachada
    //Devolucion
    //Enviar de regreso
}
