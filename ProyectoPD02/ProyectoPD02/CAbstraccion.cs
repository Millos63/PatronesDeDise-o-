using System.Collections.Generic;

namespace ProyectoPD02
{
    ///Clase CAbstraccion
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 11-10-2022
    ///Versión: 1.0
    internal class CAbstraccion
    {
        //Referencia a la implementacion
        IBridge implementacion;
        Dictionary<string, double> alumnos;

        //Metodo 1, el mas usual
        //Constructor, recibimos la implementacion concreta

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo 1. Constructor de la clase CAbstraccion
        /// </summary>
        /// <param name="pImp"></param>
        /// <param name="pAlumn"></param>
  
        public CAbstraccion(IBridge pImp, Dictionary<string, double> pAlum)
        {
            implementacion = pImp;
            alumnos = pAlum;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo 2 nos sirve para llamar cada implementación
        /// </summary>
        /// <param name="pTipo"></param>
        /// <param name="pAlumn"></param>
   
        public CAbstraccion(int pTipo, Dictionary<string, double> pAlum)
        {
            if (pTipo == 1)
                implementacion = new CImplementacion1();
            if (pTipo == 2)
                implementacion = new CImplementacion2();
            if (pTipo == 3)
                implementacion = new CImplementacion3();
            if (pTipo == 4)
                implementacion = new CImplementacion4();

            alumnos  = pAlum;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce que nos ayuda a mostrar los totales, 
        /// </summary>
   

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(alumnos);
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 11-10-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a litar los alumnos
        /// </summary>
        public void Listar()
        {
            implementacion.ListarAlumnos(alumnos);
        }
    }
}
