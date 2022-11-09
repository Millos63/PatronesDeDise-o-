using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal interface IFabrica
    {
        void crearProductos();

        IProductoLeche ObtenProductoLeche { get; }

        IProductoSaborizante ObtenSabor { get; }
    }
}
