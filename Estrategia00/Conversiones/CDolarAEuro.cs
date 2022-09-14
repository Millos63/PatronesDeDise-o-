        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class CDolarAEuro : IConversion
    {
        public double conversion(double a)
        {
            double b = 1;
            return a * b;
        }
    }
}
