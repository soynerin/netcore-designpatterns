using System;

namespace Template
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cantidad = 0;
            string tipo = string.Empty;
            IPrimitiva calidad = null;
            double total = 0;

            Console.WriteLine("1-Barato, 2-Normal");
            tipo = Console.ReadLine();

            if (tipo == "1")
            {
                calidad = new Barato();
            }

            if (tipo == "2")
            {
                calidad = new Normal();
            }

            Console.WriteLine("Cuantos juguetes a producir?");
            cantidad = Convert.ToInt32(Console.ReadLine());

            var algoritmo = new Algoritmo();
            total = algoritmo.MetodoTemplate(calidad, cantidad);

            Console.WriteLine($"El total es {total}");
        }
    }
}
