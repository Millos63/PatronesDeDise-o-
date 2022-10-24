using System;

namespace Subsistemas
{
    internal class CFachada
    {
        //Variables para guardar el numero de productos 
        public int cb3 = 2;
        public int cb4 = 2;
        public int cb5 = 2;
        public int px = 2;
        public int gt = 2;

        //Variables para preguntarle al cliente 
        string leer = "";
        int opc = 0;

        //Estos son los subsistemas que se estan utilizando
        private CSistemaCompras compra = new CSistemaCompras();
        private CSubsistemaAlmacen almacen = new CSubsistemaAlmacen();
        private CSubsistemaEnvio envio = new CSubsistemaEnvio();


        //Para la devolucion
        private CSubsistemaAlmacen devolucion1 = new CSubsistemaAlmacen();


        private CSubsistemaDevolucion devolucion = new CSubsistemaDevolucion();
        private CSubsistemaEnvioDev envioDev = new CSubsistemaEnvioDev();


        //Este metodo es usada para realizar de forma sencilla una operacion
        //mas compleja que requiere de uno o varios subsistemas

        public void Compra()
        {
            almacen.Inicializar(cb3, cb4, cb5, px, gt);
            opc = 0;
            while (opc != 6)
            {
                Console.WriteLine("Elije que cubo quieres comprar: \n" +
                "1.Cubo 3x3 \n" +
                "2.Cubo 4x4 \n" +
                "3.Cubo 5x5 \n" +
                "4.Cubo piraminx \n" +
                "5.Cubo ghost \n" +
                "6. Salir del programa\n");
                leer = Console.ReadLine();
                opc = Convert.ToInt32(leer);

                if (opc == 1 || opc == 2 || opc == 3 || opc == 4 || opc == 5)
                {
                    if (compra.Comprar())
                    {
                        if (almacen.SacarAlmacen(opc))
                        {
                            envio.EnviarPedido();
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------");

                
            }
            
        }

        public void Devolucion()
        {
            opc = 0; 
            while (opc != 6)
            {
                Console.WriteLine("Elije que cubo quieres devolver: \n" +
                "1.Cubo 3x3 \n" +
                "2.Cubo 4x4 \n" +
                "3.Cubo 5x5 \n" +
                "4.Cubo piraminx \n" +
                "5.Cubo ghost \n" +
                "6. Salir del programa\n");
                leer = Console.ReadLine();
                opc = Convert.ToInt32(leer);

                if (opc == 1 || opc == 2 || opc == 3 || opc == 4 || opc == 5)
                {

                    if (devolucion1.RegresarAlmacen(opc))
                    {
                        envioDev.EnviarPedido();
                    }

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------");
            }
        }
    }

}

