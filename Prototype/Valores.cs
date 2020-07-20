using System;

namespace Prototype
{
    /// <summary>
    /// Simulamos que esta clase tiene un constructor costoso
    /// </summary>
    internal class Valores : IPrototipo
    {
        private int m;
        private double sumatoria;

        public int M { get => m; set => m = value; }

        public double Sumatoria { get => sumatoria; set => sumatoria = value; }

        public Valores()
        {

        }

        /// <summary>
        /// Constructor costoso
        /// </summary>
        /// <param name="m"></param>
        public Valores(int m)
        {
            this.m = m;
            int n;

            for (n = 0; n < 90; n++)
            {
                sumatoria += Math.Sin(n * 0.0175);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }

        public object Clonar()
        {
            Valores clon = new Valores
            {
                M = m,
                Sumatoria = sumatoria
            };

            return clon;
        }
    }
}
