using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
    ///Interface IFabrica
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    interface IFabrica
    {
        void crearProtesis();
        IElementoElectrico ObtenElementoElectrico { get; }
        IElementoElectrico ObtenElementoElectrico2 { get; }
        IElementoElectrico ObtenElementoElectrico3 { get; }

        IElementoMetal ObtenElementoMetal { get; }

        IElementoPlastico ObtenElementoPlastico { get; }
    }
}
