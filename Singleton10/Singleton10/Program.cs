using System;

namespace Singleton10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //No se puede obtener la instancia directamente
            //CSingleton single = new CSingleton();

            //Obtenemos la instancia, se crea por primera vez
            CSingleton uno = CSingleton.ObtenInstancia();

            // Hacemos algo con la instancia
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();

            Console.WriteLine(uno);
            Console.WriteLine("------");

            //Obtenemos la instancia
            CSingleton dos = CSingleton.ObtenInstancia();
            dos.PonerDatos("Ana", 28);
            dos.AlgunProceso();
            // Comprobamos que es la misma instancia 
            // Si lo es, tendra el mismo estado
            Console.WriteLine(dos);
        }
    }
}
