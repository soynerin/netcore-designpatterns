using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            //Construimos un auto basico
            BuilderNomal builderNormal = new BuilderNomal();
            director.Construir(builderNormal);

            var auto1 = builderNormal.ObtenerProducto();
            auto1.MostrarAuto();

            Console.WriteLine("----------");
            Console.WriteLine("----------");

            //Construimos un auto deportivo
            var builderEspecial = new BuilderEspecial();
            director.Construir(builderEspecial);

            var auto2 = builderEspecial.ObtenerProducto();
            auto1.MostrarAuto();

            Console.WriteLine("----------");
        }
    }
}
