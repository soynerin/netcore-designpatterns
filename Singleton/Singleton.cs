using System;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton instancia;
        private string nombre;
        private int edad;

        private Singleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static Singleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton();

                Console.WriteLine("Instancia creada por primera vez");
            }

            return instancia;
        }

        public override string ToString()
        {
            return $"La persona {nombre} tiene {edad} años";
        }

        public void InsertarDatos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
