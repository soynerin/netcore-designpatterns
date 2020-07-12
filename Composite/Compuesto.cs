using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Compuesto<T> : IComponente<T>
    {
        public T Nombre { get; set; }

        List<IComponente<T>> elementos;

        public Compuesto(T nombre)
        {
            Nombre = nombre;
            elementos = new List<IComponente<T>>();
        }

        public void Adicionar(IComponente<T> elemento)
        {
            elementos.Add(elemento);
        }

        public IComponente<T> Borrar(T elemento)
        {
            var elementoEcontrado = Buscar(elemento);

            if (elementoEcontrado != null)
            {
                (this as Compuesto<T>).elementos.Remove(elementoEcontrado);
            }
            
            return this;
        }

        public IComponente<T> Buscar(T elemento)
        {
            if (Nombre.Equals(elemento))
            {
                return this;
            }

            IComponente<T> encontrado = null;

            foreach (IComponente<T> item in elementos)
            {
                encontrado = item.Buscar(elemento);

                if (encontrado != null)
                {
                    break;
                }
            }

            return encontrado;
        }

        public string Mostrar(int profundidad)
        {
            StringBuilder infoElemento = new StringBuilder(new string('-', profundidad));

            infoElemento.Append($"Compueto: {Nombre}. Elementos: {elementos.Count} \r\n");

            foreach (var elemento in elementos)
            {
                infoElemento.Append(elemento.Mostrar(profundidad + 1));
            }

            return infoElemento.ToString();
        }
    }
}
