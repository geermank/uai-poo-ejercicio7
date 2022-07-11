using System.Collections.Generic;

namespace ClassLibrary1
{
    public class DietaHerbibora : Dieta
    {
        private List<string> plantas;

        public DietaHerbibora(List<string> plantas) : base("Dieta a base de plantas e insectos")
        {
            this.plantas = plantas;
        }

        public List<string> Plantas
        {
            get { return plantas; }
        }
    }
}