using System;

namespace _3erParcialPatrones
{
    internal class CFabricaDinamica : IFabrica
    {
        /// <summary>
        /// CAMBIO EN GIT
        /// </summary>

        private int elemento = 0;

        private IElementoPlastico partesPlasticas;
        private IElementoMetal partesMetalicas;
        private IElementoElectrico partesElectricas;
        public IElementoPlastico ObtenElementoPlastico { get { return partesPlasticas; } }
        public IElementoMetal ObtenElementoMetal { get { return partesMetalicas; } }
        public IElementoElectrico ObtenElementoElectrico { get { return partesElectricas; } }

       /* public CFabricaDinamica(int pElemento)
        {
            elemento = pElemento;
        }*/

        public void crearProtesis()
        {
            string material = "";

            Console.WriteLine("Que plastico le gustaria ocupar para la creacion de su protesis dinamica? " +
            "\n 1: Latex. 2000" +
            "\n 2: PVC. 2500 " +
            "\n 3: Silicona 2800");
            material = Console.ReadLine();
            if (material == "1")
            {
                partesPlasticas = new CLatex();

            }
            else if (material == "2")
            {
                partesPlasticas = new CPvc();
            }
            else
            {
                partesPlasticas = new CSilicona();
            }

            Console.WriteLine("Que metal le gustaria ocupar para la creacion de su protesis dinamica?" +
           "\n 1. Acero: 4000 " +
           "\n 2. Aluminio: 5000" +
           "\n 3. Fibra de carbono: 6000");
            material = Console.ReadLine();
            if (material == "1")
            {
                partesMetalicas = new CAcero();
            }
            else if (material == "2")
            {
                partesMetalicas = new CAluminio();
            }
            else
            {
                partesMetalicas = new CFibraDeCarbono();
            }



        }
    }
}
