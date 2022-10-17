using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{
    ///Clase CCompuesto
    ///Implementa IComponente
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 11-10-2022
    ///Versión: 1.0
    internal class CCompuesto<T> : IComponente<T>
    {
        //Lista donde guardamos los elementos que va a guardar
        List<IComponente<T>> elementos;

        //Identificador
        public T Nombre { get; set; }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo constructor de CCompuesto
        /// </summary>
        /// <param name="pNombre"></param>
        
        public CCompuesto(T pNombre)
        {
            Nombre = pNombre;

            //Instanciamos la lista
            elementos = new List<IComponente<T>>();
        }
        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, Nos sirve para adicionar elementos
        /// </summary>
        /// <param name="pElemento"></param>
        public void Adicionar(IComponente<T> pElemento)
        {
            elementos.Add(pElemento);
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, Nos sirve para borrar elementos
        /// </summary>
        /// <param name="pElemento"></param>
        public IComponente<T> Borrar(T pElemento)
        {
            //Buscamos el elemento a borrar
            IComponente<T> elemento = this.Buscar(pElemento);

            //Si la encontramos, la eliminamos de la lista
            if (elemento != null)
            {
                (this as CCompuesto<T>).elementos.Remove(elemento);
            }

            return this;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, solo se pone para buscar elementos
        /// </summary>
        /// <param name="pElemento"></param>
        public IComponente<T> Buscar(T pElemento)
        {
            //Si somos quien se busca nos regresamos
            if (Nombre.Equals(pElemento))
                return this;

            IComponente<T> encontrado = null;

            //Recorremos la lista y buscamos en nuestro elementos
            foreach (IComponente<T> elemento in elementos)
            {
                encontrado = elemento.Buscar(pElemento);
                if (encontrado != null)
                    break;
            }
            return encontrado;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que implementa IComponente, Nos sirve para mostrar los elementos, junto con elementos que contenga
        /// </summary>
        /// <param name="pProfundidad"></param>
        public string Mostrar(int pProfundidad)
        {
            //Construimos la cadena con una cantidad de - igual a la profundidad
            StringBuilder infoElemento = new StringBuilder(new String('-', pProfundidad));

            //Adicionamos la informacion del compuesto
            infoElemento.Append( Nombre + " " + "\r\n");
            //Adicionamos los elementos
            foreach (IComponente<T> elemento in elementos)
                infoElemento.Append(elemento.Mostrar(pProfundidad + 1));

            return infoElemento.ToString();
        }
    }
}
