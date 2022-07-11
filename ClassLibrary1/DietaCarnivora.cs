using System.Collections.Generic;

namespace ClassLibrary1
{
    public class DietaCarnivora : Dieta
    {
        private List<Animal> presas;

        public DietaCarnivora(List<Animal> presas) : base("Dieta a base de otros animales")
        {
            this.presas = presas;
        }

        public List<Animal> Presas
        {
            get { return presas; }
        }
    }
}