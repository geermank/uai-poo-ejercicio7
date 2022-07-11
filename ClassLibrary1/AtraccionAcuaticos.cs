namespace ClassLibrary1
{
    public class AtraccionAcuaticos : Atraccion
    {
        public AtraccionAcuaticos(string nombre, float precio) : base(nombre, precio)
        {
        }

        protected override bool CorrespondeAgregarlo(Animal animal)
        {
            return animal is AnimalAcuatico;
        }
    }
}