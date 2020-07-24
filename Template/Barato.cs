namespace Template
{
    internal class Barato : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            return 2 * cantidad;
        }

        public double Empacar(int cantidad)
        {
            return 20 * cantidad;
        }
    }
}
