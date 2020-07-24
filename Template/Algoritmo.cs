using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    class Algoritmo
    {
        /// <summary>
        /// Calcula el costo total de un juguete
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public double MetodoTemplate(IPrimitiva tipo, int cantidad)
        {
            double total = 0;

            total += CrearJuguete(cantidad);

            total += tipo.Decorar(cantidad);

            VerificarCalidad();

            total += tipo.Empacar(cantidad);

            return total;
        }

        private void VerificarCalidad()
        {
            Console.WriteLine("Pasa el control de calidad");
        }

        private double CrearJuguete(int cantidad)
        {
            Console.WriteLine($"Estamos creando {cantidad} juguetes");

            return 16.5 * cantidad;
        }
    }
}
