using System;

namespace Decorator
{
    class AudioDecorador : IComponente
    {
        IComponente decoramosA;

        public AudioDecorador(IComponente componente)
        {
            decoramosA = componente;
        }

        public override string ToString()
        {
            return $"Phone Equipo Alpine Ilx-107 Apple Carplay Exclusivo\r\n {decoramosA}";
        }

        public double CalcularCosto()
        {
            return decoramosA.CalcularCosto() + 70500;
        }

        public string HacerFuncionar()
        {
            return decoramosA.HacerFuncionar() + " Audio encendido.";
        }
    }
}
