using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador06
{
    //Esta clase es el adaptador, usa la interfaz ITarget la cual es conocida 
    //por el cliente
    //El adaptador comunica al cliente con la clase adaptada
    internal class CAdaptador : ITarget
    { 
        CCalculadoraArray adaptado = new CCalculadoraArray();

        //Aqui hacemos la adaptacion de una operacion
        public int Sumar(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envian
            int[] operadores = {pA, pB};

            //Realizamos la operacion en el adaptado
            r = adaptado.suma(operadores);

            //Adaptamos el resultado
            return (int)r;
        }

        public int Resta(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envian
            int[] operadores = { pA, pB };

            //Realizamos la operacion en el adaptado
            r = adaptado.resta(operadores);

            //Adaptamos el resultado
            return (int)r;
        }

        public int Multiplicar(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envian
            int[] operadores = { pA, pB };

            //Realizamos la operacion en el adaptado
            r = adaptado.multiplicar(operadores);

            //Adaptamos el resultado
            return (int)r;
        }

        public int Dividir (int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envian
            int[] operadores = { pA, pB };

            //Realizamos la operacion en el adaptado
            r = adaptado.dividir(operadores);

            //Adaptamos el resultado
            return (int)r;
        }
    }
}
