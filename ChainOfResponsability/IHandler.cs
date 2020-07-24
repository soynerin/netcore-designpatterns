using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    interface IHandler
    {
        public double CalcularPrecioFinal(int cantidad, double precio);
    }
}
