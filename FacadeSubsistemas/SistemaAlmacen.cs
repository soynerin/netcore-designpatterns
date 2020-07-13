using System;

namespace FacadeSubsistemas
{
    public class SistemaAlmacen
    {
        private int cantidad;
        
        public SistemaAlmacen()
        {
            cantidad = 3;
        }

        public bool SacarProductoDelAlmacen()
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para enviarse!");

                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ya no hay stock!");

                return false;
            }
        }
    }
}
