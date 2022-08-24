using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class CDolarAYen : IConversion
    {
        public double conversion(double a)
        {
            double b = 137.06;
            return a * b;
        }
    }
}
