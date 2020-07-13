using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Receta : IFlyweight
    {
        /// <summary>
        /// Representa el estado intrínseco
        /// </summary>
        string nombre;
        double costo;

        /// <summary>
        /// Representa el estado extrínseco
        /// </summary>
        double venta;

        public void CalcularCosto()
        {
            foreach (var item in nombre)
            {
                costo += (int)item;
            }

            venta = costo * 1.3;
        }

        public void ColocarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"{nombre} cuesta {costo}");
        }

        public string ObtenerNombre()
        {
            return nombre;
        }
    }
}
