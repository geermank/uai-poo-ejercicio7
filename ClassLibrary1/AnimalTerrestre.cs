namespace ClassLibrary1
{
    public class AnimalTerrestre : Animal
    {
        private int cantidadDePatas;
        private bool poseeExoesqueleto;

        public AnimalTerrestre(string nombre, 
                               string lugarDeHabitat, 
                               Dieta dieta, 
                               long inicioExistenciaEnAños, 
                               long finExistenciaEnAños,
                               int cantidadDePatas,
                               bool poseeExoesqueleto) : base(nombre, lugarDeHabitat, dieta, inicioExistenciaEnAños, finExistenciaEnAños)
        {
            this.cantidadDePatas = cantidadDePatas;
            this.poseeExoesqueleto = poseeExoesqueleto;
        }

        public int CantidadDePatas
        {
            get
            {
                return cantidadDePatas;
            }
        }

        public bool PoseeExoesqueleto
        {
            get
            {
                return poseeExoesqueleto;
            }
        }
    }
}