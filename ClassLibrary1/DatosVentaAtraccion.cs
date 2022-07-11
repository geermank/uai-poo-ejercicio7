namespace ClassLibrary1
{
    public class DatosVentaAtraccion
    {
        private Atraccion atraccion;
        private int cantVentas;
        private float totalRecaudado;

        public DatosVentaAtraccion(Atraccion atraccion, int cantVentas, float totalRecaudado)
        {
            this.atraccion = atraccion;
            this.cantVentas = cantVentas;
            this.totalRecaudado = totalRecaudado;
        }

        public int CantVentas
        {
            get { return cantVentas; }
        }

        public float TotalRecaudado
        {
            get { return totalRecaudado; }
        }
    }
}