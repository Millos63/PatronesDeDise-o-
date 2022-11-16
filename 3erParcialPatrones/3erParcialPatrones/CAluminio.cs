using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CAluminio
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    class CAluminio : IElementoMetal
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a fabricar el material
        /// </summary>
        public void fabricar()
        {
            Console.WriteLine("Fabricando el aluminio que se ocupara");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver los datos del material
        /// </summary>
        public string obtenDatos()
        {
            return "ALUMINIO: Ligera, resistente y de larga duracion. Tiene una excelente conductividad de la electricidad";
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a obtener el costo del material
        /// </summary>
        public int costo()
        {
            return 5000;
        }
    }
}
