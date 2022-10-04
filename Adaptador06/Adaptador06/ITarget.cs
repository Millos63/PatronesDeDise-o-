using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador06
{
    //esta es la interface que conoce el cliente
    internal interface ITarget
    {
        int Sumar(int pA, int pB);

        int Resta(int pA, int pB);

        int Multiplicar(int pA, int pB);

        int Dividir(int pA, int pB);

    }
}
