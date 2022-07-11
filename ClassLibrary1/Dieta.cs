namespace ClassLibrary1
{
    public abstract class Dieta
    {
        private string descripcion;

        public Dieta(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string Descripcion
        {
            get { return descripcion; }
        }
    }
}