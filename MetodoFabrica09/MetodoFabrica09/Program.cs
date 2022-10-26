﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoFabrica09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuánto dinero tienes para tu vehiculo");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            //Obtenemos el vehiculo de la fabrica
            vehiculo = CCreador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();
        }
    }
}
