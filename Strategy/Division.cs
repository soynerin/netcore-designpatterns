namespace Strategy
{
    class Division : IOperacion
    {
        public double RealizarOperacion(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }

            return 0;
        }
    }
}
