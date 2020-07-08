namespace Strategy
{
    class Resta : IOperacion
    {
        public double RealizarOperacion(double a, double b)
        {
            return a - b;
        }
    }
}
