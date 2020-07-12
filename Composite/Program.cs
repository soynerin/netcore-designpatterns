using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("root");
            IComponente<string> trabajo = arbol;

            string opcion = string.Empty;
            string dato = string.Empty;

            while (opcion != "6")
            {
                Console.WriteLine($"Estoy en {trabajo.Nombre}");
                Console.WriteLine("1-Adicionar Compuesto; 2-Adicionar Componente; 3-Borrar; 4-Buscar; 5-Mostrar; 6-Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("----------");

                if (opcion == "1")
                {
                    Console.WriteLine("Dame el nombre del Compuesto: ");
                    dato = Console.ReadLine();

                    IComponente<string> c = new Compuesto<string>(dato);
                    trabajo.Adicionar(c);
                    trabajo = c;
                }

                if (opcion == "2")
                {
                    Console.WriteLine("Dame el nombre del Componente: ");
                    dato = Console.ReadLine();

                    IComponente<string> c = new Componente<string>(dato);
                    trabajo.Adicionar(c);
                }

                if (opcion == "3")
                {
                    Console.WriteLine("Dame el elemento a borrar: ");
                    dato = Console.ReadLine();

                    trabajo = trabajo.Borrar(dato);
                }

                if (opcion == "4")
                {
                    Console.WriteLine("Dame el elemento a buscar: ");
                    dato = Console.ReadLine();

                    trabajo = arbol.Buscar(dato);
                }

                if (opcion == "5")
                {
                    Console.WriteLine(arbol.Mostrar(0));
                }
            }
        }
    }
}
