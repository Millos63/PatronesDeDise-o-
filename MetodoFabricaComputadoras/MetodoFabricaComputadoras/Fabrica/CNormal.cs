using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CNormal:IComputadora
    {
        public void TipoComputadora()
        {
            Console.WriteLine("Computadora Normal");
        }
        public void Procesador()
        {
            Console.WriteLine("Procesador: Intel core I5 6ta gen");
        }

        public void TarjetaGrafica()
        {
            Console.WriteLine("Tarjeta Grafica: Intel UHD graphics ");
        }

        public void MemoriaRam()
        {
            Console.WriteLine("Memoria RAM: 8GB");
        }

        public void Almacenamiento()
        {
            Console.WriteLine("Almacenamiento: HD 512 gb");
        }

        
    }
}
