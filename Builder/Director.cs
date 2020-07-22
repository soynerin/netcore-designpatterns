namespace Builder
{
    internal class Director
    {
        /// <summary>
        /// El Director indica los pasos para hacer la construcción,
        /// pero el constructor es el que se encarga de construir según la especifiación
        /// </summary>
        /// <param name="constructor"></param>
        public void Construir(IBuilder constructor)
        {
            constructor.ConstruirCarroceria();
            constructor.ConstruirMotor();
            constructor.ConstruirRuedas();
        }
    }
}
