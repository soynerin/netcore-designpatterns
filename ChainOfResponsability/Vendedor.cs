using System;

namespace ChainOfResponsability
{
    internal class Vendedor : IHandler
    {
        private readonly IHandler siguiente = null;

        public Vendedor(IHandler siguiente)
        {
            this.siguiente = siguiente;
        }

        public double CalcularPrecioFinal(int cantidad, double precio)
        {
            Console.WriteLine("Con el Vendedor");

            double total = cantidad * precio;

            if (cantidad > 20 || total > 2000)
            {
                total = siguiente.CalcularPrecioFinal(cantidad, precio);
            }
            else
            {
                if (cantidad > 10)
                {
                    total *= 0.95;
                }
            }


            return total;
        }
    }
}
