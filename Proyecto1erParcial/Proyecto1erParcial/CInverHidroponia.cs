﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    ///Clase CInverHidroponia
    ///Implementa IComponente
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 14-09-2022
    ///Versión: 1.0
    class CInverHidroponia : IComponente
    {
        private string nombre;
        private double costo;

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Este es el metodo constructor de la clase CInverHidroponia
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pCosto"></param>
        public CInverHidroponia(string pNombre, double pCosto)
        {
            nombre = pNombre;
            costo = pCosto;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo para sobreesvribir mi string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Invernadero: {0} \n\r", nombre);
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de interfaz que implementamos
        /// </summary>
        /// <returns></returns>
        public double Costo()
        {
            return costo;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 14-09-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de interfaz que implementamos
        /// </summary>
        /// <returns></returns>
        public string Funciona()
        {
            return "Se construyo un invernadero de hidroponia";
        }
    }
}
