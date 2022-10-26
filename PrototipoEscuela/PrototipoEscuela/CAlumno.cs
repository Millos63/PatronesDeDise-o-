using System;
using System.Collections.Generic;
using System.Text;

namespace PrototipoEscuela
{
    internal class CAlumno : IPrototipo
    {
        private string nombre;
        private string materia;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Materia { get => materia; set => materia = value; }
        public CAlumno(string pNombre, string pMateria)
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
            CAlumno clon = new CAlumno(nombre, materia);
            return clon;
        }
    }
}
