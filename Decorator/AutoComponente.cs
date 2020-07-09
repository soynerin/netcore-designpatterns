using System;

namespace Decorator
{
    class AutoComponente : IComponente
    {
        private string modelo;
        private string carateristicas;
        private double costo;

        public AutoComponente(string modelo, string carateristicas, double costo)
        {
            this.modelo = modelo;
            this.carateristicas = carateristicas;
            this.costo = costo;
        }

        public override string ToString()
        {
            return $"{modelo}, {carateristicas}";
        }

        public double CalcularCosto()
        {
            return costo;
        }

        public string HacerFuncionar()
        {
            return "Motor encendido.";
        }
    }
}
