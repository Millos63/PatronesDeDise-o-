using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal interface IComputadora
    {
        void TipoComputadora();
        void Procesador();
        void TarjetaGrafica();
        void MemoriaRam();
        void Almacenamiento();

    }
}
