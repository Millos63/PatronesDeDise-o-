using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{
    ///Clase CImplementacion1
    ///Implementa IBridge
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 11-10-2022
    ///Versión: 1.0
    internal class CImplementacion1 : IBridge
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
                Console.WriteLine(p.Key);

            }
        }

    }
}
