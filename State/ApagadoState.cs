using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class ApagadoState : State
    {
        // Referencia a la clase de contexto
        private Vehiculo v;

        // Constructor que inyecta la dependencia en la clase actual
        public ApagadoState(Vehiculo v)
        {
            this.v = v;
        }

        public void Acelerar()
        {
            // Acelerar con el vehiculo apagado no sirve de mucho 🙂
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }

        public void Frenar()
        {
            // Frenar con el vehiculo parado tampoco sirve de mucho...
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }

        public void Contacto()
        {
            // Comprobamos que el vehiculo disponga de combustible
            if (v.CombustibleActual > 0)
            {
                // El vehiculo arranca -> Cambio de estado
                //estado = PARADO;
                v.Estado = new ParadoState(v);
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                v.VelocidadActual = 0;
            }
            else
            {
                // El vehiculo no arranca -> Sin combustible
                //estado = SIN COMBUSTIBLE
                v.Estado = new SinCombustibleState(v);
                Console.WriteLine("El vehiculo se encuentra sin combustible");
            }
        }
    }
}
