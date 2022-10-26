using System;
using System.Collections.Generic;
using System.Text;

namespace PrototipoEscuela
{
    internal class CAdministrativo : IPrototipo
    {
        private string nombre;
        private string cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public CAdministrativo(string pNombre, string pCargo)
        {
            nombre = pNombre;
            cargo = pCargo;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", nombre, cargo);
        }

        public object Clonar()
        {
            CAdministrativo clon = new CAdministrativo(nombre, cargo);
            return clon;
        }


        
    }
}
