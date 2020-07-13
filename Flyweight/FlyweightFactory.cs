using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class FlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();

        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adicionar(string nombre)
        {
            bool existe = false;

            foreach (IFlyweight flyweight in flyweights)
            {
                if (flyweight.ObtenerNombre() == nombre)
                {
                    existe = true;
                }
            }

            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                Receta receta = new Receta();
                receta.ColocarNombre(nombre);
                flyweights.Add(receta);

                conteo = flyweights.Count;
                return conteo - 1;
            }
        }

        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}
