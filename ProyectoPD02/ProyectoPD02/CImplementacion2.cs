using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{
    ///Clase CImplementacion2
    ///Implementa IBridge
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 11-10-2022
    ///Versión: 1.0
    internal class CImplementacion2 : IBridge
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
            //Solo lo llamamos para que no muestre error el IBridge
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
                    Console.WriteLine("{0}", p.Key);
            }
            foreach (KeyValuePair<string, double> p in pAlumnos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (p.Key[0] == 'M')
                    Console.WriteLine("{0}", p.Key, p.Value);
            }
            foreach (KeyValuePair<string, double> p in pAlumnos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'A')
                    Console.WriteLine("{0}", p.Key);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\n");

        }
    }
}
