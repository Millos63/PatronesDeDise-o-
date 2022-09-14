using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class CVerde : IOperacion
    {
        public double operacion(double j, double xl, double l, double m, double s, double p)
        {
            //Variable para calcular el precio del jitomate verde según el precio del rojo.
            double pV = p / 2;
            //Variable para retornar el resultado.
            double resultado = (j * (pV + 20)) + (xl * pV) + (l * (pV - 20)) + (m * (pV - 40)) + (s * (pV - 60));

            return resultado;
            

          

        }
    }
}
