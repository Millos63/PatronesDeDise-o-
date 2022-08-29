using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el componente central con tipo IComponente
            //Para permitir la decoración
            IComponente miAuto = new CAuto("2018", "4 puertas", 200000);

            Console.WriteLine(miAuto);

            //Si necesitamos usar un metodo propio de CAuto
            //Necesitamos hacer uso de un type cast
            ((CAuto)miAuto).Puertas(true);

            Console.WriteLine("-----------");

            // Decoramos el auto con un sistema de sonido
            miAuto = new CSistemaSonido(miAuto);

            //Comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------");

            //Ahora decoramos el auto con el nitrogeno
            miAuto = new CNitrogeno(miAuto);

            //Comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            //Para usar algo propio del Nitrogeno necesitamos un type cast
            ((CNitrogeno)miAuto).UsaN();

            Console.WriteLine("-----------");

            //Ahora decoramos el auto con la suspension
            miAuto = new CSuspension(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------------");

            //Ojo no podemos usar metodos especificos una vez que 
            //decoramos sobre ella

            //((CNitrogeno)miAuto).UsaN();
            //((CAuto)miAuto).Puertas(false);


            //////Lo que nosotros agregamos
           
            //Ahora decoramos el auto con las luces
            miAuto = new CLuces(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------------");





        }
    }
}
