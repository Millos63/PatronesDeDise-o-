using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProxy
{
    public class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxySencillo : ISujeto
        {
            private CInvernadero invernadero;

            public void Peticion(int pOpcion)
            {
                if (invernadero == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    invernadero = new CInvernadero();
                }
                if (pOpcion == 1)
                    invernadero.Carga();
                if (pOpcion == 2)
                    invernadero.CamionesLlenos(3);
            }
        }

        public class ProxySeguro : ISujeto
        {
            private CInvernadero invernadero;

            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if(password == "rojos123")
                {
                    if(invernadero == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        invernadero = new CInvernadero();
                    }

                    if (pOpcion == 1)
                        invernadero.Carga();
                    if (pOpcion == 2)
                        invernadero.CamionesLlenos(3);
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }
        }

        //Esta es la clase protegida
        private class CInvernadero
        {
            public void Carga()
            {
                Console.WriteLine("100 XL");
                Console.WriteLine("200 L");
                Console.WriteLine("50 M");
                Console.WriteLine("50 S");
            }

            public void CamionesLlenos(int n)
            {
                Console.WriteLine("Cargando {0} camiones", n);
            }
        }


    }
}
