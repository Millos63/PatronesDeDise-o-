using System;
using System.Collections.Generic;
using System.Text;

namespace PrototipoEscuela
{
    internal class CMaestro : IPrototipo
    {
        private string nombre;
        private string materia;

        //Como  son private, si queremos modificarlos en el program, tenemos que sacar los get y set 
        public string Nombre { get => nombre; set => nombre = value}
        public string Materia { get => materia; set => materia = value; }
        public CMaestro(string pNombre, string pMateria)
        {
            nombre = pNombre;
            materia = pMateria;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, materia);
        }

        public object Clonar()
        {
            CMaestro clon = new CMaestro(nombre, materia);
            return clon;
        }
    }
}
