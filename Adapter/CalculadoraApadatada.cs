namespace Adapter
{
    class CalculadoraApadatada
    {
        public double RealizarSumaAdpatada(int[] operandos)
        {
            double resultado = 0;

            foreach (var operando in operandos)
            {
                resultado += operando;
            }

            return resultado;
        }
    }
}
