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
            IComponente miCafe; 

            //Preguntamos a usuario que tipo de cafe quiere
            Console.WriteLine("Qué cafe quieres? \n\r 1.Cafe normal. \n\r2.Cafe Oaxaca. \n\r3.Cafe Veracruz \n\r4.Descafeinado \n\r5.Cafe Arabe \n\r6.Salir");
            opc = Console.ReadLine();
            cafe = Convert.ToInt32(opc);

            while(cafe != 6)
            {
                if(cafe == 1)
                {
                    //Creamos el componente crentral con tipo IComponente
                    miCafe = new CCNormal("Normal", 10);
                    Console.WriteLine(miCNormal);

                    //Preguntamos si quiere un extra
                    Console.WriteLine("Deseas agregar un complemento? 1.Azucar, \n\r2.Miel, \n\r3.Panela, \n\r4.Leche, \n\r5.Crema, \n\r6.CremaBatida, \n\r7.Chocolate \n\r8.Salir");
                    opc2 = Console.ReadLine();
                    complemento = Convert.ToInt32(opc2);

                    while (complemento != 8)
                    {
                        if (complemento == 8)
                            break;


                        if (complemento == 1)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CAzucar(miCNormal);
                        }

                        if (complemento == 2)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CMiel(miCNormal);
                        }

                        if (complemento == 3)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CPanela(miCNormal);
                        }

                        if (complemento == 4)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CLeche(miCNormal);
                        }

                        if (complemento == 5)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CCrema(miCNormal);
                        }

                        if (complemento == 6)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CCremaBatida(miCNormal);
                        }

                        if (complemento == 7)
                        {
                            //Decoramos el cafe con Azucar
                            miCNormal = new CChocolate(miCNormal);
                        }



                    }
                    
                
                }

                if(cafe == 2)
                {
                    //Creamos el componente crentral con tipo IComponente
                    IComponente miCOaxaca = new CCOaxaca("Oaxaca", 15);

                    Console.WriteLine(miCOaxaca);

                    //Decoramos el cafe con caf 
                    miCOaxaca = new CAzucar(miCOaxaca);
                    //Comprobamos la adicion de las caracteristicas
                    Console.WriteLine(miCOaxaca.Funciona());
                    Console.WriteLine(miCOaxaca.Costo());
                    break;
                }

                while(componentes)
                //Comprobamos la adicion de las caracteristicas
                Console.WriteLine(miCafe.Funciona());
                Console.WriteLine("A pagar: " + miCNormal.Costo() + " pesos");
            }


            
           
            
        }
    }
}