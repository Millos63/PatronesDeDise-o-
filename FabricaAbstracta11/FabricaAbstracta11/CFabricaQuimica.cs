using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaAbstracta11
{
    internal class CFabricaQuimica: IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new CLecheVaca();
            sabor = new CSaborChocolate();
        }
    }
}
