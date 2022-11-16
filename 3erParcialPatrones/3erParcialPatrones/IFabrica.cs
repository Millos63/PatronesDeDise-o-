using System;
using System.Collections.Generic;
using System.Text;

namespace _3erParcialPatrones
{
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
