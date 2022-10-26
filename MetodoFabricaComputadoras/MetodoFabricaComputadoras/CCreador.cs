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
            if (pSumatoria < 28)
                temp = new CSencilla();
            else if (pSumatoria < 40)
                temp = new CNormal();
            else if (pSumatoria < 52)
                temp = new CGamer();
            else if (pSumatoria < 64)
                temp = new CMac();
            else
                temp = new CSencilla();


            return temp;

        }
    }
}
