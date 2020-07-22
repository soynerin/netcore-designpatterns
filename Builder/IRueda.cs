namespace Builder
{
    internal interface IRueda
    {
        string MostrarDetalles();
    }

    internal class RuedaBasica : IRueda
    {
        public string MostrarDetalles()
        {
            return "Llantas de 14 pulgadas";
        }
    }

    internal class RuedaEspecial : IRueda
    {
        public string MostrarDetalles()
        {
            return "Llantas de 21 pulgadas";
        }
    }
}
