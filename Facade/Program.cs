using FacadeSubsistemas;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();

            fachada.Comprar();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------");

            fachada.Comprar();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------");

            fachada.Comprar();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------");

            fachada.Comprar();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------");
        }
    }
}
