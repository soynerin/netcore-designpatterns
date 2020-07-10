using System;
using System.Collections.Generic;

namespace Bridge
{
    class ImplementacionA : IBridge
    {
        public void ListarProductos(Dictionary<string, double> productos)
        {
            Console.WriteLine();
            Console.WriteLine("Listado de Productos");

            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Key);
            }
        }

        public void MostrarTotalesProductos(Dictionary<string, double> productos)
        {
            double total = 0;
            int cantidad = 0;

            foreach (var producto in productos)
            {
                total += producto.Value;
                cantidad++;
            }

            Console.WriteLine($"{cantidad} productos con un total de: ${total}");
        }
    }
}
