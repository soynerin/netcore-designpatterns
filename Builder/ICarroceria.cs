namespace Builder
{
    internal interface ICarroceria
    {
        string MostrarCaracteristicas();
    }

    internal class CarroceriaBasica : ICarroceria
    {
        public string MostrarCaracteristicas()
        {
            return "Carroceria de metal";
        }
    }

    internal class CarroceriaEspecial : ICarroceria
    {
        public string MostrarCaracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }
}
