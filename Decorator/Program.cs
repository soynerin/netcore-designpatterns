using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente miAuto = new AutoComponente("Ford Raptor F-100", "Cabina Doble", 6394500);

            Console.WriteLine(miAuto);

            Console.WriteLine();
            Console.WriteLine("---- Decoramos con Nitrógeno ----");
            miAuto = new NitrogenoDecorador(miAuto);

            Console.WriteLine("Costo: " + miAuto.CalcularCosto());
            Console.WriteLine(miAuto.HacerFuncionar());
            Console.WriteLine(miAuto);

            Console.WriteLine();
            Console.WriteLine("---- Decoramos con Equipo de Audio ----");
            miAuto = new AudioDecorador(miAuto);

            Console.WriteLine("Costo: " + miAuto.CalcularCosto());
            Console.WriteLine(miAuto.HacerFuncionar());
            Console.WriteLine(miAuto);
        }
    }
}
