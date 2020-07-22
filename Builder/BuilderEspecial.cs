namespace Builder
{
    internal class BuilderEspecial : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstruirCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public void ConstruirMotor()
        {
            auto.ColocarMotor(new MotorEspecial());
        }

        public void ConstruirRuedas()
        {
            auto.ColocarRuedas(new RuedaEspecial());
        }

        public Producto ObtenerProducto()
        {
            return auto;
        }
    }
}
