namespace FactoryMethod
{
    internal class Creador
    {
        public static IVehiculo MetodoFabrica(int plataDiponible)
        {
            IVehiculo temp = null;

            // Seleccionamos el tipo de instancia según nuetras reglas
            if (plataDiponible > 1000000)
            {
                temp = new Avion();
            }
            else if (plataDiponible > 200000)
            {
                temp = new Auto();
            }
            else
            {
                temp = new Bicicleta();
            }

            return temp;
        }
    }
}
