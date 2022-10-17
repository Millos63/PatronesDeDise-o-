using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    internal class CFachada
    {
        //Estos son los subsistemas que se estan utilizando
        private CSistemaCompras compra = new CSistemaCompras();
        private CSubsistemaAlmacen almacen = new CSubsistemaAlmacen();
        private CSubsistemaEnvio envio = new CSubsistemaEnvio();  

        //Este metodo es usada para realizar de forma sencilla una operacion
        //mas compleja que requiere de uno o varios subsistemas

        public void Compra()
        {
            if(compra.Comprar())
            {
                if(almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }
        }
    }
}
