using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    class Program
    {

        static void Main(string[] args)
        {
            //variables
            string opc = "";

            //Interfaz de usuario
            while(opc != "4")
            {
                Console.WriteLine("---------ROJOS-----------\n\r" +
                "Bienvenido a la interfaz de usuario para la empresa ROJOS.\n\r" +
                "Cuál es la acción que le gustaria realizar?\n\r" +
                "1. Venta de jitomate \n\r" +
                "2. Construir un nuevo invernadero \n\r" +
                "3. Pagar nomina \n\r" +
                "4. Salir");
                opc = Console.ReadLine();

                //1. Venta de jitomate //Patrón estrategia
                if(opc == "1")
                {
                    //Variables para guardar el numero de cajas de jitomates de los distintos tamaños
                    double j = 0;
                    double xl = 0;
                    double l = 0;
                    double m = 0;
                    double s = 0;

                    //Variable para mandar el numero de cajas a las clases
                    double r = 0;
                    
                    //Variables extras que serviran para el buen funcionamiento.
                    double costoJitomate = 0;
                    string fecha = DateTime.Now.Date.ToString(); 
                    double color = 0;
                    string leer = "";

                    string salir = "";

                    double ventaFinal = 0;

                    //Nuestra variable que referencia al algoritmo
                    //Instanciamos con un default para permitir compilacion correcta
                    IOperacion miOperacion = new CVerde();

                    //Solo preguntamos el precio del jitomate rojo, ya que de ese se sacan los demas precios
                    Console.WriteLine("\n\r Bienvenido al area de venta de ROJOS" + "\n\rCuál es el precio de la caja de jitomate rojo en la central de abastos al dia de hoy {0}?", fecha);
                    leer = Console.ReadLine();
                    costoJitomate = Convert.ToDouble(leer);

                    while(salir != "2")
                    {

                        //El precio del jitomate cambia dependiendo que color se venda, pero todo en base al precio de la caja de jitomate XL del color rojo
                        Console.WriteLine("Qué color se va a vender?\n\r" +
                        "1. Verdes, 2. verde-naranja, 3. Naranjas, 4. Rojos ");
                        leer = Console.ReadLine();
                        color = Convert.ToInt32(leer);

                        Console.WriteLine("\n\rTamaños. Cuántas cajas tienes de?:" +
                            "Jumbo:");
                        leer = Console.ReadLine();
                        j = Convert.ToDouble(leer);

                        Console.WriteLine("\n\rXL:");
                        leer = Console.ReadLine();
                        xl = Convert.ToDouble(leer);

                        Console.WriteLine("\n\rL:");
                        leer = Console.ReadLine();
                        l = Convert.ToDouble(leer);

                        Console.WriteLine("\n\rM:");
                        leer = Console.ReadLine();
                        m = Convert.ToDouble(leer);

                        Console.WriteLine("\n\rSmall:");
                        leer = Console.ReadLine();
                        s = Convert.ToDouble(leer);


                        //Verdes 
                        if (color == 1)
                        {
                            Console.WriteLine("El precio de la caja de jitomate XL verde es de{0}", costoJitomate/2);
                            miOperacion = new CVerde();
                            r = miOperacion.operacion(j, xl, l, m, s, costoJitomate);
                            Console.WriteLine("Se vendio un total de {0} pesos de jitomate verde", r);
                        }

                        //verdeNaranja
                        if (color == 2)
                        {
                            Console.WriteLine("El precio de la caja de jitomate XL verde-naranja es de{0}", costoJitomate - 20);
                            miOperacion = new CVerdeNaranja();
                            r = miOperacion.operacion(j, xl, l, m, s, costoJitomate);
                            Console.WriteLine("Se vendio un total de {0} pesos de jitomate verde-naranja", r);
                        }

                        //Naranjas
                        if (color == 3)
                        {
                            Console.WriteLine("El precio de la caja de jitomate XL naranja es de{0}", costoJitomate + 20);
                            miOperacion = new CNaranja();
                            r = miOperacion.operacion(j, xl, l, m, s, costoJitomate);
                            Console.WriteLine("Se vendio un total de {0} pesos de jitomate naranja", r);
                        }

                        //Rojos
                        if (color == 4)
                        {
                            Console.WriteLine("El precio de la caja de jitomate XL rojo es el valor que usted nos proporciono, {0}", costoJitomate);
                            miOperacion = new CRojo();
                            r = miOperacion.operacion(j, xl, l, m, s, costoJitomate);
                            Console.WriteLine("Se vendio un total de {0} pesos de jitomate rojo", r);
                        }

                        ventaFinal += r; 

                        Console.WriteLine("Deseas vender mas jitomates de otro color? 1.Si, 2.No");
                        salir = Console.ReadLine();
                        
                    }

                    Console.WriteLine("\n\r Se obtuvieron {0} de ventas totales\n\r", ventaFinal);
                    
                }

                //2. Construir un nuevo invernadero //DECORADOR
                if(opc == "2")
                {
                    
                    string opc2 = "";
                    int invernadero = 0;
                    int complemento = 0;

                    //Variable IComponente para guardar el cafe seleccionado.

                    IComponente miCafe = new CCNormal("Normal", 0);


                    while (invernadero != 6)
                    {
                        //Preguntamos a usuario que tipo de invernadero quiere
                        Console.WriteLine("Qué invernadero le gustaria construir? \n\r 1.Cafe normal. \n\r2.Cafe Oaxaca. \n\r3.Cafe Veracruz \n\r4.Descafeinado \n\r5.Cafe Arabe \n\r6.Salir");
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

                //3. Pagar nomina // PROXY
                if (opc == "3")
                {

                }

            }


        }
    }
}
