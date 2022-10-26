using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica09
{
    internal class CBici: IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Las bicis no necesitan encendido");
        }

        public void Acelerar()
        {
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void Frenar()
        {
            Console.WriteLine("Presione el freno trasero primero");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio");
        }
    }
}
