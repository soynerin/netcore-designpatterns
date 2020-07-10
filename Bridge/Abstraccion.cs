using System.Collections.Generic;

namespace Bridge
{
    class Abstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public Abstraccion(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }

        public Abstraccion(int tipoImplementacion, Dictionary<string, double> productos)
        {
            switch (tipoImplementacion)
            {
                case 1:
                    implementacion = new ImplementacionA();
                    break;

                case 2:
                    implementacion = new ImplementacionB();
                    break;
            }

            this.productos = productos;
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotalesProductos(this.productos);
        }

        public void Listar()
        {
            implementacion.ListarProductos(this.productos);
        }
    }
}
