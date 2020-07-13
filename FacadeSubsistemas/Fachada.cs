namespace FacadeSubsistemas
{
    public class Fachada
    {
        SistemaCompra sistemaCompra = new SistemaCompra();
        SistemaAlmacen sistemaAlmacen = new SistemaAlmacen();
        SistemaEnvio sistemaEnvio = new SistemaEnvio();

        public void Comprar()
        {
            if (sistemaCompra.EfectuarCompra())
            {
                if (sistemaAlmacen.SacarProductoDelAlmacen())
                {
                    sistemaEnvio.EnviarPedido();
                }
            }
        }
    }
}
