
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica09
{
    //Aqui implementamos la fabrica
    internal class CCreador
    {
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;

            //Seleccionamos el tipo de instancia segun nuestras reglas
            if (pDinero > 10000000)
                temp = new CAvion();
            else if (pDinero > 2000000)
                temp = new CAuto();
            else
                temp = new CBici();

            return temp;

        }
        
    }
}
