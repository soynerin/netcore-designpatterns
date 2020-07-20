using System;

namespace FactoryMethod
{
    internal class Auto : IVehiculo
    {
        public Auto()
        {
            Console.WriteLine("Instanciando Auto");
        }

        public void Acelerar()
        {
            Console.WriteLine("Apretar el acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Colocar la llave y girarla");
        }

        public void Frenar()
        {
            Console.WriteLine("Apretar el freno");
        }

        public void Girar()
        {
            Console.WriteLine("Tomar volante y girar");
        }
    }
}
