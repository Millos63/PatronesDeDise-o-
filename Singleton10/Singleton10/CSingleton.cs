using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton10
{
    internal class CSingleton
    {
        //Aqui guardamos la unica instancia que va a existir
        private static CSingleton instancia;

        //Datos propios de la clase
        private string nombre;
        private int edad;

        //Creamos el constructor privado
        //Esto significa que nadie del exterior puede crearlo
        private CSingleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static CSingleton ObtenInstancia()
        {
            // Verificamos si no existe la instancia
            if(instancia == null)
            {
                //Si no existe, instanciamos
                instancia = new CSingleton();

                Console.WriteLine("----Instancia creada por primera vez ----");

            }
            
            //Regresamos la instancia

            return instancia;
        }

        //Metodos propios de la clase

        public override string ToString()
        {
            return String.Format("La persona {0}, tiene edad de {1}", nombre, edad);
        }

        public void PonerDatos(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        //Esto representa cualquier otro objeto
        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo", nombre);
        }


    }
}
