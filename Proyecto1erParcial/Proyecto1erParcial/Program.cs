using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1erParcial
{
    ///Esta clase se encarga de correr todo el programa
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 14-09-2022
    ///Versión: 1.0

    class Program
    {

        static void Main(string[] args)
        {
            //variables globales
            string opc = "";
            string leer = "";

            //Interfaz de usuario
            while (opc != "4")
            {
                Console.WriteLine("---------ROJOS-----------\n\r" +
                "Bienvenido a la interfaz de usuario para la empresa ROJOS.\n\r" +
                "Cuál es la acción que le gustaria realizar?\n\r" +
                "1. Venta de jitomate \n\r" +
                "2. Construir un nuevo invernadero \n\r" +
                "3. Información nomina\n\r" +
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
                    double metros = 0;
                    //Variable IComponente para guardar el invernadero seleccionado.

                    IComponente miInvernadero = new CInverTierra("Tierra", 0);


                    while (invernadero != 4)
                    {
                        //Preguntamos a usuario que tipo de invernadero quiere
                        Console.WriteLine("Qué tipo de invernadero le gustaria construir? \n\r1.Invernadero de Tierra. \n\r2.Invernadero Hidroponico. \n\r3.Invernadero Holandes \n\r4. Salir");
                        opc = Console.ReadLine();
                        invernadero = Convert.ToInt32(opc);

                        if (invernadero == 4)
                            break;

                        //Preguntamos cuantos metros cuadrados va a construir
                        Console.WriteLine("Cuántos metros cuadrados tendra el invernadero?");
                        leer = Console.ReadLine();
                        metros = Convert.ToDouble(leer) ;

                        if (invernadero == 4)
                            break;
                        if (invernadero == 1)
                        {
                            //Le agregamos a miInvernadero el invernadero de tierra
                            miInvernadero = new CInverTierra("Invernadero de tierra", 30 * metros);
                            Console.WriteLine(miInvernadero);
                        }

                        if (invernadero == 2)
                        {
                            //Le agregamos a miInvernadero el invernadero de tierra
                            miInvernadero = new CInverHidroponia("Invernadero hidroponico", 50 * metros);
                            Console.WriteLine(miInvernadero);
                        }

                        if (invernadero == 3)
                        {
                            //Le agregamos a miInvernadero el invernadero de tierra
                            miInvernadero = new CInverHolandes("Invernadero holandes", 70 * metros);
                            Console.WriteLine(miInvernadero);


                        }

                        //Preguntamos si quiere extras en su invernadero

                        while (complemento != 5)
                        {

                            Console.WriteLine("que cosas le gustaria agregar extra a su invernadero, 1.Cortinas electricas, \n\r2.Sistema automatico de riego, \n\r3.Cajon de abejorros, \n\r4.Robot cosechador,\n\r5.Salir");
                            opc2 = Console.ReadLine();
                            complemento = Convert.ToInt32(opc2);
                            if (complemento == 1)
                            {
                                //Decoramos el invernadero con cortinas electricas
                                miInvernadero = new CCortinasElectricas(miInvernadero, metros);
                            }

                            if (complemento == 2)
                            {
                                //Decoramos el invernadero con el sistema automatico de riego
                                miInvernadero = new CSistemaRiego(miInvernadero,metros);
                            }

                            if (complemento == 3)
                            {
                                //Decoramos el invernadero con el cajon de abejorros
                                miInvernadero= new CCajonAbejorros(miInvernadero);
                            }

                            if (complemento == 4)
                            {
                                //Decoramos el invernadero con un robot cosechador
                                miInvernadero= new CCosechadorAutomatico(miInvernadero);
                            }


                        }

                    }


                    Console.WriteLine(miInvernadero.Funciona());
                    Console.WriteLine("El costo total de construcción, ya con todos los componentes extra es de: " + miInvernadero.Costo());
                    //Console.WriteLine(miInvernadero);


                }

                //3. Pagar nomina // PROXY
                if (opc == "3")
                {
                    CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();

                    miProxyS.Peticion(1);
                    Console.WriteLine("------");
                    
                }

            }


        }
    }
}
