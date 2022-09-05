using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();

            miProxy.Peticion(1);
            Console.WriteLine("------");
            miProxy.Peticion(2);

            Console.WriteLine("-------");

            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();

            miProxy.Peticion(1);
            Console.WriteLine("------");
            miProxyS.Peticion(2);
        }
    }
}
