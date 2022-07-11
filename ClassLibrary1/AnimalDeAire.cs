namespace ClassLibrary1
{
    public class AnimalDeAire : Animal
    {
        private int distanciaDeVision;
        private int velocidadDeVuelo;

        public AnimalDeAire(string nombre, 
                            string lugarDeHabitat, 
                            Dieta dieta, 
                            long inicioExistenciaEnAños, 
                            long finExistenciaEnAños,
                            int distanciaDeVision,
                            int velocidadDeVuelo) : base(nombre, lugarDeHabitat, dieta, inicioExistenciaEnAños, finExistenciaEnAños)
        {
            this.distanciaDeVision = distanciaDeVision;
            this.velocidadDeVuelo = velocidadDeVuelo;
        }

        public int DistanciaDeVision
        {
            get { return distanciaDeVision; }
        }

        public int VelocidadDeVuelo
        {
            get { return velocidadDeVuelo; }
        }
    }
}