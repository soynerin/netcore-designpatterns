using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 0;

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> ComidasRapidas = new List<int>();

            FlyweightFactory flyweightFactory = new FlyweightFactory();

            indice = flyweightFactory.Adicionar("Hamburguesa");
            Carnes.Add(indice);
            ComidasRapidas.Add(indice);

            indice = flyweightFactory.Adicionar("Cabello de Angel");
            Sopas.Add(indice);

            indice = flyweightFactory.Adicionar("Cesar con Pollo");
            ComidasRapidas.Add(indice);

            indice = flyweightFactory.Adicionar("Pizza");
            ComidasRapidas.Add(indice);

            indice = flyweightFactory.Adicionar("Sanguche de Milanesa");
            ComidasRapidas.Add(indice);
            Carnes.Add(indice);

            foreach (var item in ComidasRapidas)
            {
                Receta receta = (Receta)flyweightFactory[item];
                receta.CalcularCosto();
                receta.MostrarInfo();
            }

            Console.WriteLine("----------");
        }
    }
}
