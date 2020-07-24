using System;

namespace ChainOfResponsability
{
    internal class JefePiso : IHandler
    {
        private readonly IHandler siguiente;

        public JefePiso(IHandler siguiente)
        {
            this.siguiente = siguiente;
        }

        public double CalcularPrecioFinal(int cantidad, double precio)
        {
            Console.WriteLine("Con el Jefe de Piso");

            double total = cantidad * precio;

            if (cantidad > 100 || total > 75000)
            {
                total = siguiente.CalcularPrecioFinal(cantidad, precio);
            }
            else
            {
                if (cantidad > 20)
                {
                    total *= .9;
                }
            }


            return total;
        }
    }
}
