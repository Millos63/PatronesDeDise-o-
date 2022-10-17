using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    internal class CFachada
    {
        //Variables para guardar el numero de productos 
        public int cb3 = 5;
        public int cb4 = 5;
        public int cb5 = 5;
        public int px = 5;
        public int gt = 5;

        //Variables para preguntarle al cliente 
        string leer = "";
        int opc = 0;
        
        //Estos son los subsistemas que se estan utilizando
        private CSistemaCompras compra = new CSistemaCompras();
        private CSubsistemaAlmacen almacen = new CSubsistemaAlmacen();
        private CSubsistemaEnvio envio = new CSubsistemaEnvio();  

        
        //Para la devolucion
        private CSubsistemaDevolucion devolucion = new CSubsistemaDevolucion();
        //Este metodo es usada para realizar de forma sencilla una operacion
        //mas compleja que requiere de uno o varios subsistemas

        public void Compra()
        {
            almacen.Inicializar(cb3,cb4,cb5,px,gt);
            
            Console.WriteLine("Bienvenido a la tienda de cubos rubik. Elije que cubo quieres comprar: \n" +
                "1.Cubo 3x3 {0} \n" +
                "2.Cubo 4x4 {1}\n" +
                "3.Cubo 5x5 {2}\n" +
                "4.Cubo piraminx {3} \n" +
                "5.Cubo ghost {4}\n", cb3, cb4, cb5, px, gt);
            leer = Console.ReadLine();
            opc = Convert.ToInt32(leer);
            
            if(compra.Comprar())
            {
                if(almacen.SacarAlmacen(opc))
                {
                    envio.EnviarPedido();
                }
            }
        }
    }
}
