using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Clase CSingleton
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    internal class CSingleton
    {
        //Aqui guardamos la unica instancia que va a existir
        private static CSingleton instancia;

        //Datos propios de la clase

        private int costoFinal;

        //Creamos el constructor privado
        //Esto significa que nadie del exterior puede crearlo


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo 1. Constructor de la clase CSingleton
        /// </summary>
        private CSingleton()
        {
            costoFinal = 0;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo para obtener una instancia
        /// </summary>
        public static CSingleton ObtenInstancia()
        {
            // Verificamos si no existe la instancia
            if (instancia == null)
            {
                //Si no existe, instanciamos
                instancia = new CSingleton();

                Console.WriteLine("-------Realizando Unico Pago--------");

            }

            //Regresamos la instancia
            return instancia;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo propio de la clase
        /// </summary>
        public override string ToString()
        {
            return String.Format("El monto a pagar por la protesis es de: {0} ", costoFinal);
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo que sirve para ponerDatos a la instancia
        /// </summary>
        public void PonerDatos(int pCostoFInal)
        {
            costoFinal = pCostoFInal;
        }

        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo para procesaer el pago del cliente
        /// </summary>
        public void ProcesandoPago()
        {
            Console.WriteLine("El pago por {0} ha sido procesado, gracias por la compra!!", costoFinal);
        }
    }
}
