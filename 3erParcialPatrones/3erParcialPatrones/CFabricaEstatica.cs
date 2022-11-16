using System;

namespace _3erParcialPatrones
{
    ///Clase CFabricaEstatica
    ///Autor: Emigdio Espinosa Jasso
    ///Fecha: 16-11-2022
    ///Versión: 1.0
    internal class CFabricaEstatica : IFabrica
    {
        private IElementoPlastico partesPlasticas;
        private IElementoMetal partesMetalicas;

        public IElementoPlastico ObtenElementoPlastico { get { return partesPlasticas; } }
        public IElementoMetal ObtenElementoMetal { get { return partesMetalicas; } }

        //En esta protesis no se ocuparan elementos electricos, pero lo llamamos para que no haya error con la interfaz
        public IElementoElectrico ObtenElementoElectrico { get; }
        public IElementoElectrico ObtenElementoElectrico2 { get; }
        public IElementoElectrico ObtenElementoElectrico3 { get; }

        string opc;
        string material;


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo 1. Constructor de la clase CFabricaEstatica
        /// </summary>
        /// <param name="pOpc"></param>
        public CFabricaEstatica(string pOpc)
        {
            opc = pOpc;

        }


        ///Autor: Emigdio Espinosa Jasso
        ///Fecha: 16-11-2022
        ///Versión: 1.0
        /// <summary>
        /// Metodo de la interfaz que el usuario conoce, nos ayuda a Crear la protesis
        /// </summary>
        public void crearProtesis()
        {

            if (opc == "1")
            {
                Console.WriteLine("Que material le gustaria ocupar: " +
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
            }
            else if (opc == "2")
            {
                Console.WriteLine("Que material le gustaria ocupar: " +
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
}
