using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    internal class CSingleton
    {
        //Aqui guardamos la unica instancia que va a existir
        private static CSingleton instancia;

        //Datos propios de la clase

        private int costoFinal;

        //Creamos el constructor privado
        //Esto significa que nadie del exterior puede crearlo
        private CSingleton()
        {
            costoFinal = 0;
        }

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

        //Metodos propios de la clase

        public override string ToString()
        {
            return String.Format("El monto a pagar por la protesis es de: {0} ", costoFinal);
        }

        public void PonerDatos(int pCostoFInal)
        {
            costoFinal = pCostoFInal;
        }

        //Esto representa cualquier otro objeto
        public void ProcesandoPago()
        {
            Console.WriteLine("El pago por {0} ha sido procesado, gracias por la compra!!", costoFinal);
        }
    }
}
