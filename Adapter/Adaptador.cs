namespace Adapter
{
    class Adaptador : ITarget
    {
        CalculadoraApadatada CalculadoraApadatada = new CalculadoraApadatada();

        public int Sumar(int a, int b)
        {
            int[] operandos = { a, b };
            double resultado = 0;

            resultado = CalculadoraApadatada.RealizarSumaAdpatada(operandos);

            return (int)resultado;
        }
    }
}
