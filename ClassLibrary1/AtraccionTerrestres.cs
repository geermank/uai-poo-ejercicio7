namespace ClassLibrary1
{
    public class AtraccionTerrestres : Atraccion
    {
        public AtraccionTerrestres(string nombre, float precio) : base(nombre, precio)
        {
        }

        protected override bool CorrespondeAgregarlo(Animal animal)
        {
            return animal is AnimalTerrestre;
        }
    }
}