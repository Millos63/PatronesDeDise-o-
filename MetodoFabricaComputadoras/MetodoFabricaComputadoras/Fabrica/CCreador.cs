using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class CCreador
    {
        
        public static IComputadora MetodoFabrica(int pSumatoria)
        {

            IComputadora temp = null;

            //Seleccionamos el tipo de instancia segun nuestras reglas
            if (pSumatoria == 1)
                temp = new CSencilla();
            else if (pSumatoria == 2)
                temp = new CNormal();
            else if (pSumatoria == 3)
                temp = new CMac();
            else if (pSumatoria == 4)
                temp = new CGamer();
            


            return temp;

        }
    }
}
