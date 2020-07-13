using System;

namespace FacadeSubsistemas
{
    public class SistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Tu pedido esta en camino!");
        }
    }
}
