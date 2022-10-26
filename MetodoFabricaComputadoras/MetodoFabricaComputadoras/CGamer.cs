using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CGamer:IComputadora
    {
        public void Procesador()
        {
            Console.WriteLine("Procesador: Intel Core I5 11gen ");
        }

        public void TarjetaGrafica()
        {
            Console.WriteLine("Tarjeta Grafica: NVIDIA GTX2060");
        }

        public void MemoriaRam()
        {
            Console.WriteLine("Memoria RAM: 16GB");
        }

        public void Almacenamiento()
        {
            Console.WriteLine("Almacenamiento: SSD 512 gb");
        }
    }
}
