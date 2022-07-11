using System.Collections.Generic;

namespace ClassLibrary1
{
    public abstract class Atraccion
    {
        private string nombre;
        private float precio;
        private List<Animal> animales;

        public Atraccion(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.animales = new List<Animal>();
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public float Precio
        {
            get { return precio; }
        }

        public List<Animal> Animales
        {
            get { return animales; }
        }

        public void AgregarAnimal(Animal animal)
        {
            if (CorrespondeAgregarlo(animal)) 
            {
                animales.Add(animal);
            }
        }

        protected abstract bool CorrespondeAgregarlo(Animal animal);
    }
}