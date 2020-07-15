namespace Adapter
{
    class Calculadora : ITarget
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
