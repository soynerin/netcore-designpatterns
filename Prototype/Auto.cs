using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Auto : IPrototipo
    {
        private string modelo;
        private int costo;

        public string Modelo { get => modelo; set => modelo = value; }

        public Auto(string modelo, int costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }
        public override string ToString()
        {
            return $"{modelo} : {costo}";
        }

        public object Clonar()
        {
            return new Auto(modelo, costo);
        }
    }
}
