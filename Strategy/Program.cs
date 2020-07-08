using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {           
            string opcionClienteSeleccionada = null;
            IOperacion tipoOperacion = new Suma();

            Console.WriteLine();
            Console.WriteLine("-------- CALCULADORA USANDO STRATEGY PATTERN --------");
            Console.WriteLine("------------- OPERACIÓN CON DOS NÚMEROS -------------");
            Console.WriteLine();

            while (opcionClienteSeleccionada != "5")
            {
                Console.WriteLine("Seleccioná una opción: 1-Suma; 2-Resta; 3-Multiplicación; 4-División; 5-Salir");
                opcionClienteSeleccionada =  Console.ReadLine();

                switch (opcionClienteSeleccionada)
                {
                    case "1":
                        tipoOperacion = new Suma();
                        break;
                    case "2":
                        tipoOperacion = new Resta();
                        break;
                    case "3":
                        tipoOperacion = new Multiplicacion();
                        break;
                    case "4":
                        tipoOperacion = new Division();
                        break;
                    default:
                        return;
                }

                Console.Write("Valor para A: ");
                var valorA = Console.ReadLine();

                Console.Write("Valor para B: ");
                var valorB = Console.ReadLine();

                double a = Convert.ToDouble(valorA);
                double b = Convert.ToDouble(valorB);

                var resultadoOperacion = tipoOperacion.RealizarOperacion(a, b);

                Console.WriteLine("El resultado de la operación es: " + resultadoOperacion);
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");

            }
        }
    }
}
