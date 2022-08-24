using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class CDolarAPeso : IConversion
    {
        public double conversion(double a)
        {
            double b = 19.94;
            return a * b;
        }
    }
}
