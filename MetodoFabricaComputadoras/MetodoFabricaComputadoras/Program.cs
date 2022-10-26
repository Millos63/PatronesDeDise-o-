using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabricaComputadoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int dinero = 0;
            int gamer = 0;
            int experiencia = 0;
            int sumatoria = 0;
            string leer;
            Console.WriteLine("Bienvenido a la seleccion de computadoras");
            Console.WriteLine("Elige las opciones segun te convenga: \n" +
                "Edad: \n" +
                "1. 10-15 \n" +
                "2. 15-25 \n" +
                "3. 25-35 \n" +
                "4. 35 en adelante \n");
            leer = Console.ReadLine();

            if (leer == "1")
                edad = 4;
            else if (leer == "2")
                edad = 8;
            else if (leer == "3")
                edad = 12;
            else if (leer == "4")
                edad = 16;

            Console.WriteLine("Dinero: \n" +
                "1. 4000-8000 \n" +
                "2. 8000-15000 \n" +
                "3. 15000 - 22000 \n" +
                "4. 22000 - 25000 \n");
            leer = Console.ReadLine();

            if (leer == "1")
                dinero = 4;
            else if (leer == "2")
                dinero = 8;
            else if (leer == "3")
                dinero = 12;
            else if (leer == "4")
                dinero = 16;

            Console.WriteLine("Gamer: \n" +
                "1. Si \n" +
                "2. No \n");
            leer = Console.ReadLine();
            
            if(leer == "1")
                gamer = 8;
            else if (leer == "2")
                gamer = 16;

            Console.WriteLine("Experiencia: \n" +
                "1. Muy alta\n" +
                "2. Alta \n" +
                "3. Media\n" +
                "4. Poca \n");
            leer = Console.ReadLine();
            
            if(leer=="1")
                experiencia = 4;
            if (leer == "2")
                experiencia = 8;
            if (leer == "3")
                experiencia = 12;
            if (leer == "4")
                experiencia = 16;



            sumatoria = edad + dinero + gamer + experiencia;


            Console.WriteLine("{0}", sumatoria);






            //Edad, dinero,gamer,experiencia
            //sencilla = 4, normal = 8, gamer = 12, mac = 16
            //   < 28          <40          <52        <64  

            //Edad
            //10 - 15: 4
            //15 - 25: 8
            //25 - 35: 12
            //35....: 16

            //Dinero
            //4000 - 8000: 4
            //8000 - 15000: 8
            //15000 - 22000: 12
            //22000 - 25000: 16

            //Gamer
            // No: 8
            // Si: 16

            //Experiencia
            //Poca : 16
            //Media: 12
            //Alta: 8
            //Muy alta: 4

        }
    }
}
