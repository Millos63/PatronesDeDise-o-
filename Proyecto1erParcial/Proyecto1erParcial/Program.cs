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

                }

                //3. Pagar nomina // PROXY
                if(opc == "3")
                {

                }

            }


        }
    }
}
