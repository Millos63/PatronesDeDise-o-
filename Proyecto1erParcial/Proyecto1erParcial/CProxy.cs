using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    public class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxySeguro : ISujeto
        {
            private CNomina nomina;

            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if (password == "abc123")
                {
                    if (nomina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        nomina = new CNomina();
                    }


                    if (pOpcion == 1)
                        nomina.InfoNomina();
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }
        }

        //Esta es la clase protegida
        private class CNomina
        {
            public void InfoNomina()
            {
                Console.WriteLine("Cristobal: 3000");
                Console.WriteLine("Angel: 2500");
                Console.WriteLine("Omar: 2400");
                Console.WriteLine("Armando: 4000");
                Console.WriteLine("Nancy: 3500");
                Console.WriteLine("Ricardo: 4000");
                Console.WriteLine("Daniel: 3500");

                Console.WriteLine("Dinero en caja:  40,000");
            }

        }
    }
}

