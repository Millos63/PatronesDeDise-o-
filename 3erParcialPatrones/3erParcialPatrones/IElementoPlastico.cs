using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Interface IElementoPlastico
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    internal interface IElementoPlastico
    {
        void producir();
        string composicion();
        int costo();
    }
}
