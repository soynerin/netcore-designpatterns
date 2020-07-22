using System;

namespace Builder
{
    internal class Producto
    {
        private ICarroceria carroceria;
        private IMotor motor;
        private IRueda rueda;

        public void ColocarCarroceria(ICarroceria carroceria)
        {
            this.carroceria = carroceria;
            Console.WriteLine($"Se ha colocado la carroceria: {carroceria.MostrarCaracteristicas()}");
        }

        public void ColocarMotor(IMotor motor)
        {
            this.motor = motor;
            Console.WriteLine($"Se ha colocado el motor: {motor.MostrarEspecificaciones()}");
        }

        public void ColocarRuedas(IRueda rueda)
        {
            this.rueda = rueda;
            Console.WriteLine($"Se han colocado las ruedas: {rueda.MostrarDetalles()}");
        }

        public void MostrarAuto()
        {
            Console.WriteLine($"Tu auto tiene {motor.MostrarEspecificaciones()}, {rueda.MostrarDetalles()}, {carroceria.MostrarCaracteristicas()}");
        }
    }
}
