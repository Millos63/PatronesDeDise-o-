using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{

    ///Clase CAcero
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    class CAcero : IElementoMetal
    {

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a fabricar el material
        /// </summary>
        public void fabricar()
        {
            Console.WriteLine("Fabricando el acero que se ocupara");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver los datos del material
        /// </summary>
        public string obtenDatos()
        {
            return "ACERO: Material rigido, resistencia a la corrosion y elevada resistencia mecanica";
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a obtener el costo del material
        /// </summary>
        public int costo()
        {
            return 4000;
        }
    }
}
