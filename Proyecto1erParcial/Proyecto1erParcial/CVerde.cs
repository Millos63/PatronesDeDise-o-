using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    ///Clase CVerde
    ///Implementa IOperacion
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 14-09-2022
    ///Versión: 1.0
    class CVerde : IOperacion
    {

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que calcula el precio de los distintos tamaños de jitomate del color verde
        /// </summary>
        /// <param name="j"></param>
        /// <param name="xl"></param>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public double operacion(double j, double xl, double l, double m, double s, double p)
        {
            //Variable para calcular el precio del jitomate verde según el precio del rojo.
            double costo = p / 2;
            //Variable para retornar el resultado.
            double resultado = (j * (costo + 20)) + (xl * costo) + (l * (costo - 20)) + (m * (costo - 40)) + (s * (costo - 60));

            return resultado;
        }
    }
}
