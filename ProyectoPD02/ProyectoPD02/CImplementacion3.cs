using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{
    ///Clase CImplementacion3
    ///Implementa IBridge
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 11-10-2022
    ///Versión: 1.0
    internal class CImplementacion3 : IBridge
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que nos muestra los totales de los alumnos
        /// </summary>
        /// <param name="pAlumnos"></param>
        public void MostrarTotales(Dictionary<string, double> pAlumnos)
        {
            double total = 0;
            double totalm = 0;
            double totall = 0;
            double totala = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in pAlumnos)
            {
                total += p.Value;
                if (p.Key[0] == 'L')
                    totall += p.Value;
                if (p.Key[0] == 'M')
                    totalm += p.Value;
                if (p.Key[0] == 'A')
                    totala += p.Value;

                cantidad++;
            }
            Console.WriteLine("El total del centro deportivo Lomas es: ${0}", totall);
            Console.WriteLine("El total del centro deportivo Momoxpan es: ${0}", totalm);
            Console.WriteLine("El total del centro deportivo Aquixtla es: ${0}", totala);
            Console.WriteLine("El total de las tres sucursales es:  ${1}", cantidad, total);
            Console.WriteLine("\r\n");
        }


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que nos enlista los alumnos
        /// </summary>
        /// <param name="pAlumnos"></param>
        public void ListarAlumnos(Dictionary<string, double> pAlumnos)
        {
            foreach (KeyValuePair<string, double> p in pAlumnos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (p.Key[0] == 'L')
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            foreach (KeyValuePair<string, double> p in pAlumnos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (p.Key[0] == 'M')
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            foreach (KeyValuePair<string, double> p in pAlumnos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'A')
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\n");
        }
    }
}
