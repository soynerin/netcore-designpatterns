using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Propietario propietario = new Propietario();
            var jefePiso = new JefePiso(propietario);
            var vendedor = new Vendedor(jefePiso);

            int cantidad = 180;
            double precio = 100000;
            double total = 0;

            total = vendedor.CalcularPrecioFinal(cantidad, precio);

            Console.WriteLine($"Total {cantidad * precio} - Descuento {total}");
        }
    }
}
