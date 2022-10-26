using System;
using System.Collections.Generic;
using System.Text;

namespace PrototipoEscuela
{
    internal class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public CAdminPrototipos()
        {
            //Adicionamos los objetos prototipo con los valores iniciales que nos interesan
            //Si queremos modificar la materia, tenemos que agregar Get y Set de materia
            CAlumno alumno = new CAlumno("NombreEstudiante", "NombreMateria");
            prototipos.Add("Alumno", alumno);

            CMaestro maestro = new CMaestro("NombreProfesor", "NombreMateria");
            prototipos.Add("Maestro", maestro);

            CAdministrativo administrativo = new CAdministrativo("NombreAdmin", "NombreMateria")
            prototipos.Add("Administrativo", administrativo);
            //Los diccionarios se indexan por llaves y no por nombres
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }

        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
