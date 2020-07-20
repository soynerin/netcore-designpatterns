using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.ObtenerInstancia();
            singleton.InsertarDatos("Neri", 30);
            Console.WriteLine(singleton);

            Console.WriteLine("----------");

            var otroSingleton = Singleton.ObtenerInstancia();
            Console.WriteLine(otroSingleton);
        }
    }
}
