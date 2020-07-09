using System;

namespace Decorator
{
    class NitrogenoDecorador : IComponente
    {
        IComponente decoramosA;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="componente">Objeto que va a ser decorado</param>
        public NitrogenoDecorador(IComponente componente)
        {
            decoramosA = componente;
        }

        public override string ToString()
        {
            return $"Tubo Nitrogeno 1/2 Mt M3 + Valvula De Alta Presión\r\n {decoramosA}";
        }

        /// <summary>
        /// Se adiciona el valor del Nitrógeno al costo del Componente Auto
        /// </summary>
        /// <returns>Nuevo costo</returns>
        public double CalcularCosto()
        {
            return decoramosA.CalcularCosto() + 13500;
        }

        public string HacerFuncionar()
        {
            return $"{decoramosA.HacerFuncionar()} Sistema de Nitrógeno encendido.";
        }
    }
}
