using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------- USANDO PATRÓN PROXY --------");
            Console.WriteLine();

            //Proxy.IObject proxySencillo = new Proxy.ProxySencillo();

            //proxySencillo.Peticion(1);
            //proxySencillo.Peticion(2);

            Proxy.IObject proxySeguro = new Proxy.ProxySeguro();

            proxySeguro.Peticion(1);
            proxySeguro.Peticion(2);
        }
    }
}
