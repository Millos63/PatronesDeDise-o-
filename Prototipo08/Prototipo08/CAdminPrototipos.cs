using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo08
{
    internal class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();
        
        public CAdminPrototipos()
        {
            //Adicionamos los objetos prototipo con los valores iniciales que nos interesan
            CPersona persona = new CPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores);

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
