using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica09
{
    internal class CAuto: IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Introduce la llave y girala");
        }

        public void Acelerar()
        {
            Console.WriteLine("Oprime el pedal del acelerador");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el pedal del freno");
        }

        public void Girar()
        {
            Console.WriteLine("Toma el volante y giralo");
        }
    }
}
