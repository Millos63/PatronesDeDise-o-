using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPD02
{
    ///Interface IBridge
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 12-10-2022
    ///Versión: 1.0
    internal interface IBridge
    {

        void MostrarTotales(Dictionary<string, double> pAlumnos);
        void ListarAlumnos(Dictionary<string, double> pAlumnos);
    }
}
