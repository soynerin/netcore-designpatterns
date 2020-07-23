using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface State
    {
        void Acelerar();

        void Frenar();
        
        void Contacto();
    }
}
