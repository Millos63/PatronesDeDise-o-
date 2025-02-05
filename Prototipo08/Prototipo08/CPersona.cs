﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo08
{
    internal class CPersona :IPrototipo
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre;  set => nombre = value; } 

        public CPersona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", nombre, edad);
        }

        public object Clonar()
        {
            CPersona clon = new CPersona(nombre, edad);

            return clon;
            
        }
    }
}
