using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    ///Clase CInverTierra
    ///Implementa IComponente
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 14-09-2022
    ///Versión: 1.0
    public class CProxy
    {
        ///Interface ISujeto
        ///Implementa IComponente
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        ///Clase CProxySeguro
        ///Implementa IComponente
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        public class ProxySeguro : ISujeto
        {
            private CNomina nomina;

            ///Autor: Emigdio Espinosa Jasso
            ///Fecha: 14-09-2022
            ///Versión: 1.0
            /// <summary>
            /// Metodo de interfaz que implementamos
            /// </summary>
            /// <param name="pOpcion"></param>
            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if (password == "ROJOS")
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

        ///Clase CNomina
        ///Implementa IComponente
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        private class CNomina
        {
            ///Autor: Emigdio Espinosa Jasso
            ///Fecha: 14-09-2022
            ///Versión: 1.0
            /// <summary>
            /// Metodo que guarda el nombre de los empleados y cuanto es su salario.
            /// </summary>
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

