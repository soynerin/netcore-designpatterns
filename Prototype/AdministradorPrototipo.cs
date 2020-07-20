using System.Collections.Generic;

namespace Prototype
{
    internal class AdministradorPrototipo
    {
        private readonly Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public AdministradorPrototipo()
        {
            Persona persona = new Persona("Neri", 30);
            prototipos.Add("Persona", persona);

            Valores valores = new Valores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionarPrototipos(string llave, IPrototipo prototipo)
        {
            prototipos.Add(llave, prototipo);
        }

        public object ObtenerPrototipo(string llave)
        {
            return prototipos[llave].Clonar();
        }
    }
}
