using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            ITarget calculadora = new Calculadora();

            resultado = calculadora.Sumar(3, 90);

            Console.WriteLine($"El resultado de la suma es {resultado}");
            Console.WriteLine("----------");


            calculadora = new Adaptador();
            resultado = calculadora.Sumar(100, 76764);

            Console.WriteLine($"El resultado de la suma es {resultado}");
            Console.WriteLine("----------");
        }
    }
}
