using System;

namespace PrototipoEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos el administrador
            CAdminPrototipos admin = new CAdminPrototipos();

            //Obtenemos dos instancias
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            //Verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------");

            //Modificamos el estado
            uno.Nombre = "Ana";
            dos.Nombre = "Chepe";

            //Verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------------");

            //Creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            // Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenemos un objeto de ese prototipo
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //Cambiamos el estado
            auto2.Modelo = "Honda";

            // Verificamos que cada uno tenga su estado
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-------------");

            //Obtenemos una instancia del costoso
            CValores val = (CValores)admin.ObtenPrototipo("Valores");

            Console.WriteLine(val);


        }
    }
}
