using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class CVerdeNaranja : IOperacion
    {
        public double operacion(double j, double xl, double l, double m, double s, double p)
        {
            //Variable para calcular el precio del jitomate verde-naranja según el precio del rojo.
            double costo = p - 20;
            //Variable para retornar el resultado.
            double resultado = (j * (costo + 20)) + (xl * costo) + (l * (costo - 20)) + (m * (costo - 40)) + (s * (costo - 60));

            return resultado;
        }
    }
}
