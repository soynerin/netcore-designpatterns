using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ParadoState : State
    {
        // Referencia a la clase de contexto
        private Vehiculo v;

        // Constructor que inyecta la dependencia en la clase actual
        public ParadoState(Vehiculo v)
        {
            this.v = v;
        }

        public void Acelerar()
        {
            // Comprobamos que el vehiculo disponga de combustible
            if (v.CombustibleActual > 0)
            {
                // El vehiculo se pone en marcha. Aumenta la velocidad y cambiamos de estado
                //estado = EN_MARCHA;
                v.Estado = new EnMarchaState(v);
                Console.WriteLine("El vehiculo se encuentra ahora EN MARCHA");
                v.ModificarVelocidad(10);
                v.ModificarCombustible(-10);
            }
            else
            {
                //estado = SIN COMBUSTIBLE
                v.Estado = new SinCombustibleState(v);
                Console.WriteLine("El vehiculo se encuentra ahora SIN COMBUSTIBLE");
            }
        }

        public void Frenar()
        {
            // No ocurre nada. Si el vehiculo ya se encuentra detenido, no habra efecto alguno
            Console.WriteLine("ERROR: El vehiculo ya se encuentra detenido");
        }

        public void Contacto()
        {
            // El vehiculo se apaga
            // estado = APAGADO;
            v.Estado = new ApagadoState(v);
            Console.WriteLine("El vehiculo se encuentra ahora APAGADO");
        }
    }
}
