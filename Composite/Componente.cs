using System;

namespace Composite
{
    /// <summary>
    /// Representa el nodo Hoja
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Componente<T> : IComponente<T>
    {
        public T Nombre { get; set; }


        public Componente(T nombre)
        {
            Nombre = nombre;
        }

        public void Adicionar(IComponente<T> elemento)
        {
            Console.WriteLine("Solo se adiciona un elemento al Compuesto, no al Componente");
        }

        public IComponente<T> Borrar(T elemento)
        {
            Console.WriteLine("No se puede eliminar directamente");

            return this;
        }

        public IComponente<T> Buscar(T elemento)
        {
            if (elemento.Equals(Nombre))
            {
                return this;
            } 
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Devuelve la cantidad de guiones según la profundidad
        /// </summary>
        /// <param name="profundidad">Profundidad</param>
        /// <returns>Cantidad de guiones</returns>
        public string Mostrar(int profundidad)
        {
            return new string('-', profundidad) + Nombre + "\n\r";
        }
    }
}
