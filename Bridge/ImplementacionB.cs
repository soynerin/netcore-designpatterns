using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class ImplementacionB : IBridge
    {
        public void ListarProductos(Dictionary<string, double> productos)
        {
            Console.WriteLine();
            Console.WriteLine("Listado de Productos");

            foreach (var producto in productos)
            {
                if (producto.Key[0] == 'M')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(producto.Key);
                }

                if (producto.Key[0] == 'C')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(producto.Key);
                }

                if (producto.Key[0] == 'D')
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(producto.Key);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void MostrarTotalesProductos(Dictionary<string, double> productos)
        {
            int totalMedicamentos = 0;
            int totalDeportes = 0;
            int totalComida = 0;
            int cantidad = 0;
            double total = 0;

            foreach (var producto in productos)
            {
                cantidad++;
                total += producto.Value;

                if (producto.Key[0] == 'M')
                {
                    totalMedicamentos += 1;
                }

                if (producto.Key[0] == 'C')
                {
                    totalComida += 1;
                }

                if (producto.Key[0] == 'D')
                {
                    totalDeportes += 1;
                }
            }

            Console.WriteLine($"Total de productos de tipo Medicamentos es: {totalMedicamentos}");
            Console.WriteLine($"Total de productos de tipo Comida es: {totalComida}");
            Console.WriteLine($"Total de productos de tipo Deportes es: {totalDeportes}");
            Console.WriteLine();
            Console.WriteLine($"{cantidad} productos con un total de: ${total}");
        }
    }
}
