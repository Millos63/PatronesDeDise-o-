﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorador
{
    //Esta clase representa al componente y debe de implementar 
    //a IComponente para poder llevar a cabo la decoración.
    class CCNormal : IComponente
    {
        private string nombre;
        private double costo;

        public CCNormal(string pNombre, double pCosto)
        {
            nombre = pNombre;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Cafe: {0} \r\n", nombre);
        }

        //Estos son lo metodos implementados de IComponente
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Se sirvio un cafe normal";
        }

    }
}
