namespace Strategy
{
    class Suma : IOperacion
    {
        public double RealizarOperacion(double a, double b)
        {
            return a + b;
        }
    }
}
