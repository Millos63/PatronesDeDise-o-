using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CPvc
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    internal class CPvc : IElementoPlastico
    {
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a producir el material
        /// </summary>
        public void producir()
        {
            Console.WriteLine("Produciendo las piezas de PVC para la protesis");
        }


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a ver la composicion del material
        /// </summary>
        public string composicion()
        {
            return "PVC: Tiene buen aislamiento acustico y térmico, vida util larga"; 
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a obtener el costo del material
        /// </summary>
        public int costo()
        {
            return 2500;
        }

    }
}
