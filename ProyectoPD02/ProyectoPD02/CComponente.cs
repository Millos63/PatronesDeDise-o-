using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{
    ///Clase CComponente
    ///Implementa IComponente
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 11-10-2022
    ///Versión: 1.0
    internal class CComponente<T> : IComponente<T>
    {
        //Identificador del componente
        public T Nombre { get; set; }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo constructor de CComponente
        /// </summary>
        /// <param name="pImp"></param>
        /// <param name="pAlumn"></param>
        public CComponente(T pNombre)
        {
            Nombre = pNombre;
        }


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, solo se pone para que no marque error
        /// </summary>
        /// <param name="pElemento"></param>
        public void Adicionar(IComponente<T> pElemento)
        {
            Console.WriteLine("Solo se adiciona a los compuestos, no a los componentes");
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, sirve para borrar alumnos o centros
        /// </summary>
        /// <param name="pElemento"></param>

        public IComponente<T> Borrar(T pElemento)
        {
            Console.WriteLine("No se puede eliminar directamente");
            return this;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, sirve para buscar alumnos o centros
        /// </summary>
        /// <param name="pElemento"></param>

        public IComponente<T> Buscar(T pElemento)
        {
            if (pElemento.Equals(Nombre))
                return this;
            else
                return null;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, sirve para mostrar alumnos o centros, junto con lo que contengan.
        /// </summary>
        /// <param name="pProfundidad"></param>

        public string Mostrar(int pProfundidad)
        {
            //Colocamos la cantidad de - según la profundidad
            return new String('-', pProfundidad) + Nombre + "\n\r";

        }

    }
}
