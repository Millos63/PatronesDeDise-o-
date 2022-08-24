using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class CYenADolar : IConversion
    {
        public double conversion(double a)
        {
            double b = 0.0073;
            return a * b;
        }
    }
}
