namespace ClassLibrary1
{
    public class AtraccionAves : Atraccion
    {
        public AtraccionAves(string nombre, float precio) : base(nombre, precio)
        {
        }

        protected override bool CorrespondeAgregarlo(Animal animal)
        {
            return animal is AnimalDeAire;
        }
    }
}