using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CMac:IComputadora
    {
        public void Procesador()
        {
            Console.WriteLine("Procesador: Intel Core 2QUAD");
        }

        public void TarjetaGrafica()
        {
            Console.WriteLine("Tarjeta Grafica: Intel HD");
        }

        public void MemoriaRam()
        {
            Console.WriteLine("Memoria RAM: 16 GB");
        }

        public void Almacenamiento()
        {
            Console.WriteLine("Almacenamiento: SSD 512 GB");
        }
    }
}
