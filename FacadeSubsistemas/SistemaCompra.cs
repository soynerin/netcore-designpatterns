using System;

namespace FacadeSubsistemas
{
    public class SistemaCompra
    {
        public bool EfectuarCompra()
        {
            string dato = string.Empty;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingresar numero de tarjeta: ");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado!");

                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado!");

                return false;
            }
        }
    }
}
