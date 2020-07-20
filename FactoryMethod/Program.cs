using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("¿Cuánta plata tenés disponible?");
            var dato = Console.ReadLine();

            IVehiculo test = Creador.MetodoFabrica(Convert.ToInt32(dato));

            Console.WriteLine("");
            test.Encender();
            test.Acelerar();
            test.Girar();
            test.Frenar();
        }
    }
}
