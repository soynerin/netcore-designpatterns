namespace Template
{
    internal class Normal : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            return 9 * cantidad;
        }

        public double Empacar(int cantidad)
        {
            return 90 * cantidad;
        }
    }
}
