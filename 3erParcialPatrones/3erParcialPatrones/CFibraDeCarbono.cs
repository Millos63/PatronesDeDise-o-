using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CFibraDeCarbono
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    class CFibraDeCarbono : IElementoMetal
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a fabricar el material
        /// </summary>
        public void fabricar()
        {
            Console.WriteLine("Fabricando la fibra de carbono que se ocupara");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver los datos del material
        /// </summary>
        public string obtenDatos()
        {
            return "FIBRA DE CARBONO: Muy resistente, baja conductividad termica, excelente conductor de electricidad, material liviano";
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a obtener el costo del material
        /// </summary>
        public int costo()
        {
            return 6000;
        }
    }
}
