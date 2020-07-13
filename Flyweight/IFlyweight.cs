using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    interface IFlyweight
    {
        void ColocarNombre(string nombre);

        void CalcularCosto();

        void MostrarInfo();

        string ObtenerNombre();
    }
}
