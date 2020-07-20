namespace Prototype
{
    internal class Persona : IPrototipo
    {
        private string nombre;
        private readonly int edad;

        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"{nombre} : {edad}";
        }

        /// <summary>
        /// Acá los que nos interesa es el estado acual del objeto. No por la parte del desempeño.
        /// </summary>
        /// <returns></returns>
        public object Clonar()
        {
            Persona clon = new Persona(nombre, edad);

            return clon;
        }
    }
}
