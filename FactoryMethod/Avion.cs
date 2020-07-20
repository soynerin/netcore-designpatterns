using System;

namespace FactoryMethod
{
    internal class Avion : IVehiculo
    {
        public Avion()
        {
            Console.WriteLine("Instanciando Avión");
        }

        public void Acelerar()
        {
            Console.WriteLine("Empuja el acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Sigue todo el procedimiento");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenar =D");
        }

        public void Girar()
        {
            Console.WriteLine("Mover algo para girar");
        }
    }
}
