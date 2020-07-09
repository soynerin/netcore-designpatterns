using System;

namespace Proxy
{
    class Proxy
    {
        public interface IObject
        {
            void Peticion(int opcion);
        }

        public class ProxySencillo : IObject
        {
            Cocina cocina;

            public void Peticion(int opcion)
            {
                if (cocina == null)
                {                    
                    cocina = new Cocina();
                }

                switch (opcion)
                {
                    case 1:
                        cocina.MostrarRecetaSecreta();
                        break;
                    case 2:
                        cocina.Cocinar();
                        break;
                }
            }
        }

        public class ProxySeguro : IObject
        {
            Cocina cocina;

            public void Peticion(int opcion)
            {
                Console.WriteLine("Escribe la contraseña:");
                var password = Console.ReadLine();

                if (password != "1234")
                {
                    Console.WriteLine("Acceso denegado");
                }
                else
                {
                    if (cocina == null)
                    {                        
                        cocina = new Cocina();
                    }

                    switch (opcion)
                    {
                        case 1:
                            cocina.MostrarRecetaSecreta();
                            break;
                        case 2:
                            cocina.Cocinar();
                            break;
                    }
                }
            }
        }

        private class Cocina
        {
            public Cocina()
            {
                Console.WriteLine("Creando instancia a de Cocina");
                Console.WriteLine();
            }

            public void MostrarRecetaSecreta()
            {
                Console.WriteLine("Leche");
                Console.WriteLine("Harina");
                Console.WriteLine("Avena");
                Console.WriteLine("2 tazas de agua tibia");
                Console.WriteLine("Sal y pimienta");
                Console.WriteLine();
            }

            public void Cocinar()
            {
                Console.WriteLine("Concinando receta");
            }
        }
    }
}
