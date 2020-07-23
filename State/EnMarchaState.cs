using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EnMarchaState : State
    {
        private const int VELOCIDAD_MAXIMA = 200;

        // Referencia a la clase de contexto
        private Vehiculo v;

        // Constructor que inyecta la dependencia en la clase actual
        public EnMarchaState(Vehiculo v)
        {
            this.v = v;
        }

        public void Acelerar()
        {
            if (v.CombustibleActual > 0)
            {
                // Aumentamos la velocidad, permaneciendo en el mismo estado
                if (v.VelocidadActual >= VELOCIDAD_MAXIMA)
                {
                    Console.WriteLine("ERROR: El coche ha alcanzado su velocidad maxima");
                    v.ModificarCombustible(-10);
                }
                else
                {
                    v.ModificarVelocidad(10);
                    v.ModificarCombustible(-10);
                }
            }
            else
            {
                //estado = SIN COMBUSTIBLE
                v.Estado = new SinCombustibleState(v);
                Console.WriteLine("El vehiculo se ha quedado sin combustible");
            }
        }

        public void Frenar()
        {
            // Reducimos la velocidad. Si esta llega a 0, cambiaremos a estado "PARADO"
            v.ModificarVelocidad(-10);
            if (v.VelocidadActual <= 0)
            {
                //estado = PARADO;
                v.Estado = new ParadoState(v);
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
            }
        }

        public void Contacto()
        {
            // No se puede detener el vehiculo en marcha!
            Console.WriteLine("ERROR: No se puede cortar el contacto en marcha!");
        }
    }
}
