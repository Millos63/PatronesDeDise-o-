using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CSencilla : IComputadora
    {
        public void TipoComputadora()
        {
            Console.WriteLine("Computadora Sencilla");
        }
        public void Procesador()
        {
            Console.WriteLine("Procesador: Intel Celeron");
        }

        public void TarjetaGrafica()
        {
            Console.WriteLine("Tarjeta Grafica: Integrada");
        }

        public void MemoriaRam()
        {
            Console.WriteLine("Memoria RAM: 4GB");
        }

        public void Almacenamiento()
        {
            Console.WriteLine("Almacenamiento: HD 256 gb");
        }
    }
}
