using System.Collections.Generic;

namespace Bridge
{
    interface IBridge
    {
        void MostrarTotalesProductos(Dictionary<string, double> productos);

        void ListarProductos(Dictionary<string, double> productos);
    }
}
