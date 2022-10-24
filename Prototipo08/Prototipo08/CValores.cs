using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo08
{
    internal class CValores : IPrototipo
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria{ get => sumatoria; set => sumatoria= value; }

        public CValores()
        {
             
        }

        //Este es el constructor costoso

        public CValores(int pM)
        {
            m = pM;
            int n = 0;
            for(n = 0; n < 90; n++)
                sumatoria += Math.Sin(n * 0.0175);
        }

        public override string ToString()
        {
            return String.Format("{0}", sumatoria * m);
        }

        public object Clonar()
        {

            //Tenemos un objeto variado, pero que tendra los mismos datos que nuestro prototipo.
            CValores clon = new CValores();
            clon.M = m; 
            clon.Sumatoria = sumatoria;

            return clon;
        }
    }

}
