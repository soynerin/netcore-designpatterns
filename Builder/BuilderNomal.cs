namespace Builder
{
    internal class BuilderNomal : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstruirCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void ConstruirMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public void ConstruirRuedas()
        {
            auto.ColocarRuedas(new RuedaBasica());
        }

        public Producto ObtenerProducto()
        {
            return auto;
        }
    }
}
