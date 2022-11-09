using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    //Clase que implementa Singleton
    internal class CCaja
    {
        //Aqui guardamos la unica instancia que va a existir
        private static CCaja instancia;

        //Datos propios de la clase
        private int dinero;

        //Creamos el constructor privado
        //Esto significa que nadie del exterior puede crearlo
        private CCaja()
        {
            dinero = 0;
        }

        public static CCaja ObtenInstancia()
        {
            // Verificamos si no existe la instancia
            if (instancia == null)
            {
                //Si no existe, instanciamos
                instancia = new CCaja();

                Console.WriteLine("----Primera compra----");

            }

            //Regresamos la instancia

            return instancia;
        }

        //Metodos propios de la clase

        public override string ToString()
        {
            return String.Format("EN LA CAJA HAY {0} pesos", dinero);
        }

        public void PonerDatos(int pDinero)
        {
            dinero = pDinero;
        }

    }
}
