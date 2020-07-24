using System;

namespace ChainOfResponsability
{
    internal class Propietario : IHandler
    {

        public double CalcularPrecioFinal(int cantidad, double precio)
        {
            Console.WriteLine("Con el Propietario");

            double total = 0;

            total = cantidad * precio * 0.85;

            return total;
        }
    }
}
