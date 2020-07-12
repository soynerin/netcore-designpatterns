namespace Composite
{
    interface IComponente<T>
    {
        T Nombre { get; set; }

        void Adicionar(IComponente<T> elemento);

        IComponente<T> Borrar(T elemento);

        IComponente<T> Buscar(T elemento);

        string Mostrar(int profundidad);
    }
}
