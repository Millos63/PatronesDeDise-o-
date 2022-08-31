﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorador
{
    class CDescafeinado : IComponente
    {
        private string nombre;
        private double costo;

        public CDescafeinado(string pNombre, double pCosto)
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
            return "Se sirvio un cafe descafeinado";
        }
    }
}
