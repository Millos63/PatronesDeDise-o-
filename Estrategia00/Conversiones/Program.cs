using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double monedas = 0;
            int operacion = 0;
            string opc = "";
            double r = 0;
            //Nuestra variable que referencia al algoritmo
            //Instanciamos con un default para permitir compilacion correcta
            IConversion miConversion = new CPesosADolar();
            while (operacion != 7)
            {
                //Interfaz
                Console.WriteLine("Qué operación le gustaria realizar? 1. Peso a dolar, 2. dolar a peso, 3. yen a dolar, 4. dolar a yen, 5. euro a dolar, 6. dolar a euro, 7. salir");
                opc = Console.ReadLine();
                operacion = Convert.ToInt32(opc);

                Console.WriteLine("Cuántas monedas le gustaria cambiar?");
                opc = Console.ReadLine();
                monedas = Convert.ToDouble(opc);


                if (operacion == 1)
                    miConversion = new CPesosADolar();

                if (operacion == 2)
                    miConversion = new CDolarAPeso();

                if (operacion == 3)
                    miConversion = new CYenADolar();

                if (operacion == 4)
                    miConversion = new CDolarAYen();

                if (operacion == 5)
                    miConversion = new CEuroADolar();

                if (operacion == 6)
                    miConversion = new CDolarAEuro();

                r = miConversion.conversion(monedas);

                Console.WriteLine("El resultado es {0}", r);
            }
        






        }
    }
}
