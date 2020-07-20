using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var administradorPrototipo = new AdministradorPrototipo();

            var uno = (Persona)administradorPrototipo.ObtenerPrototipo("Persona");
            var dos = (Persona)administradorPrototipo.ObtenerPrototipo("Persona");

            Console.WriteLine(uno);
            Console.WriteLine(dos);

            Console.WriteLine("----------");

            // Modificamos el Estado
            uno.Nombre = "Merex";
            dos.Nombre = "Chuwaka";

            Console.WriteLine(uno);
            Console.WriteLine(dos);

            Console.WriteLine("----------");
            Console.WriteLine("----------");

            var auto = new Auto("Ford", 300000);
            administradorPrototipo.AdicionarPrototipos("Auto", auto);

            var auto2 = (Auto)administradorPrototipo.ObtenerPrototipo("Auto");
            auto2.Modelo = "Nissan";

            Console.WriteLine(auto);
            Console.WriteLine(auto2);

            Console.WriteLine("----------");
            Console.WriteLine("----------");

            var valores = (Valores)administradorPrototipo.ObtenerPrototipo("Valores");

            Console.WriteLine(valores);
        }
    }
}
