using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia00
{
    class CPotencia : IOperacion
    {
        public double operacion(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
