using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables globales
            string opc = "";
            string opc2 = "";
            int cafe = 0;
            int complemento = 0;

            //Variable IComponente para guardar el cafe seleccionado.

            IComponente miCafe = new CCNormal("Normal", 0);

            
            while (cafe != 6)
            {
                //Preguntamos a usuario que tipo de cafe quiere
                Console.WriteLine("Qué cafe quieres? \n\r 1.Cafe normal. \n\r2.Cafe Oaxaca. \n\r3.Cafe Veracruz \n\r4.Descafeinado \n\r5.Cafe Arabe \n\r6.Salir");
                opc = Console.ReadLine();
                cafe = Convert.ToInt32(opc);

                if (cafe == 6)
                    break;
                if (cafe == 1)
                {
                    //Le agregamos a miCafe el cafe normal.
                    miCafe = new CCNormal("Normal", 10);
                    Console.WriteLine(miCafe);
                }

                if (cafe == 2)
                {
                    //Le agregamos el CafeOaxaca a miCafe
                    miCafe = new CCOaxaca("Oaxaca", 15);
                    Console.WriteLine(miCafe);

                }

                if (cafe == 3)
                {
                    //Le agregamos el CafeVeracruz a miCafe
                    miCafe = new CCVeracruz("Veravruz", 15);
                    Console.WriteLine(miCafe);


                }

                if (cafe == 4)
                {
                    //Le agregamos el CafeDescafeinado a miCafe
                    miCafe = new CDescafeinado("Descafeinado", 17);
                    Console.WriteLine(miCafe);

                }

                if (cafe == 5)
                {
                    //Le agregamos el CafeArabe a miCafe
                    miCafe = new CCArabe("Arabe", 23);
                    Console.WriteLine(miCafe);
                }

                //Preguntamos si quiere un extra
                

                while (complemento != 8)
                {

                    Console.WriteLine("Deseas agregar un complemento? 1.Azucar, \n\r2.Miel, \n\r3.Panela, \n\r4.Leche, \n\r5.Crema, \n\r6.CremaBatida, \n\r7.Chocolate \n\r8.Salir");
                    opc2 = Console.ReadLine();
                    complemento = Convert.ToInt32(opc2);
                    if (complemento == 1)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CAzucar(miCafe);
                    }

                    if (complemento == 2)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CMiel(miCafe);
                    }

                    if (complemento == 3)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CPanela(miCafe);
                    }

                    if (complemento == 4)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CLeche(miCafe);
                    }

                    if (complemento == 5)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CCrema(miCafe);
                    }

                    if (complemento == 6)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CCremaBatida(miCafe);
                    }

                    if (complemento == 7)
                    {
                        //Decoramos el cafe con Azucar
                        miCafe = new CChocolate(miCafe);
                    }
                }

            }

            
            Console.WriteLine(miCafe.Funciona());
            Console.WriteLine("El Monto a pagar es: " + miCafe.Costo());
            Console.WriteLine(miCafe);

        }
    }
}