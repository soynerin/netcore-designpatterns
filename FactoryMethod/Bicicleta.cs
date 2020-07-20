using System;

namespace FactoryMethod
{
    internal class Bicicleta : IVehiculo
    {
        public Bicicleta()
        {
            Console.WriteLine("Instanciando Bicicleta");
            Console.WriteLine("");
        }

        public void Acelerar()
        {
            Console.WriteLine("Pedalear para acelerar");
        }

        public void Encender()
        {
            Console.WriteLine("Las bicicletas no necesitan encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("Presionar el freno de atrás primero");
        }

        public void Girar()
        {
            Console.WriteLine("Tomar el manubrio y girar");
        }
    }
}
