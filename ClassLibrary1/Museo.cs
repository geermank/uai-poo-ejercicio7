using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Museo
    {
        private List<Atraccion> atracciones;
        private List<Ingreso> ingresosRegistrados;
        private List<Pasaporte> pasaportesRegistrados;

        public List<Atraccion> Atracciones
        {
            get { return atracciones; }
        }

        public List<Ingreso> Ingresos
        {
            get { return ingresosRegistrados; }
        }

        public List<Pasaporte> Pasaportes
        {
            get { return pasaportesRegistrados; }
        }

        public List<Animal> TodosLosAnimales
        {
            get
            {
                return ObtenerTodosLosAnimales();
            }
        }

        public Museo(CreadorDeAtracciones creadorDeAtracciones)
        {
            atracciones = creadorDeAtracciones.CrearAtracciones();
            ingresosRegistrados = new List<Ingreso>();
            pasaportesRegistrados = new List<Pasaporte>();
        }

        public void AgregarAnimalDeAgua(string nombre, 
                                        string lugarDeHabitat, 
                                        Dieta dieta, 
                                        long inicioExistenciaEnAños, 
                                        long finExistenciaEnAños)
        {
            Animal animal = new AnimalAcuatico(nombre, lugarDeHabitat, dieta, inicioExistenciaEnAños, finExistenciaEnAños);
            Atraccion atraccion = atracciones.Find(a => a is AtraccionAcuaticos);
            if (atraccion != null)
            {
                atraccion.AgregarAnimal(animal);
            }
        }

        public void AgregarAnimalTerrestre(string nombre,
                                           string lugarDeHabitat,
                                           Dieta dieta,
                                           long inicioExistenciaEnAños,
                                           long finExistenciaEnAños,
                                           int cantidadDePatas,
                                           bool poseeExoesqueleto)
        {
            Animal animalTerrestre = new AnimalTerrestre(nombre, lugarDeHabitat, dieta, inicioExistenciaEnAños, finExistenciaEnAños, cantidadDePatas, poseeExoesqueleto);
            Atraccion atraccion = atracciones.Find(a => a is AtraccionTerrestres);
            if (atraccion != null)
            {
                atraccion.AgregarAnimal(animalTerrestre);
            }
        }

        public void AgregarAnimalDeAire(string nombre,
                                        string lugarDeHabitat,
                                        Dieta dieta,
                                        long inicioExistenciaEnAños,
                                        long finExistenciaEnAños,
                                        int distanciaDeVision,
                                        int velocidadDeVuelo)
        {
            Animal animal = new AnimalDeAire(nombre, lugarDeHabitat, dieta, inicioExistenciaEnAños, finExistenciaEnAños, distanciaDeVision, velocidadDeVuelo);
            Atraccion atraccion = atracciones.Find(a => a is AtraccionAves);
            if (atraccion != null)
            {
                atraccion.AgregarAnimal(animal);
            }
        }

        public Dieta CrearDietaHerbibora(List<string> comidas)
        {
            return new DietaHerbibora(comidas);
        }

        public Dieta CrearDietaCarnibora(List<Animal> presas)
        {
            return new DietaCarnivora(presas);
        }

        public void RegistrarIngreso(Pasaporte pasaporte, DateTime fecha)
        {
            ingresosRegistrados.Add(pasaporte.RegistrarIngreso(fecha));
        }

        public void CrearNuevoPasaporte(string nombre, 
                                        string apellido, 
                                        DateTime fechaNacimiento, 
                                        List<Atraccion> atraccionesDeseadas)
        {
            Persona persona = new Persona(nombre, apellido, fechaNacimiento);
            Pasaporte pasaporte = new Pasaporte(persona, atraccionesDeseadas);
            pasaportesRegistrados.Add(pasaporte);
        }

        public float TotalRecaudado
        {
            get
            {
                return ingresosRegistrados.Sum(i => i.Importe);
            }
        }

        public Atraccion ObtenerAtraccionConMasVisitantes()
        {
            Atraccion atraccionConMasVisitantes = null;
            int cantidadDeVisitantes = -1;
            foreach(Atraccion atraccion in atracciones)
            {
                var cantVisitasDeLaAtraccion = CantidadDeVisitas(atraccion);
                if (cantVisitasDeLaAtraccion != 0 && cantVisitasDeLaAtraccion >= cantidadDeVisitantes)
                {
                    atraccionConMasVisitantes = atraccion;
                }
            }
            return atraccionConMasVisitantes;
        }

        public List<DatosVentaAtraccion> ObtenerDatosDeVentasDeLasAtracciones()
        {
            List<DatosVentaAtraccion> datosVentaAtracciones = new List<DatosVentaAtraccion>();

            foreach (Atraccion atraccion in atracciones)
            {
                int cantVisitasDeLaAtraccion = CantidadDeVisitas(atraccion);
                float importeFacturadoSinDescuentos = cantVisitasDeLaAtraccion * CreadorDeAtracciones.PRECIO_BASE_DE_ATRACCIONES;
                datosVentaAtracciones.Add(new DatosVentaAtraccion(atraccion, cantVisitasDeLaAtraccion, importeFacturadoSinDescuentos));
            }

            return datosVentaAtracciones;
        }

        public Dictionary<Atraccion, int> ObtenerCantidadAnimalesPorAtraccion()
        {
            Dictionary<Atraccion, int> dict = new Dictionary<Atraccion, int>();

            foreach (Atraccion atraccion in atracciones)
            {
                int cantAnimales = atraccion.Animales.Count();
                dict.Add(atraccion, cantAnimales);
            }

            return dict;
        }

        public List<Animal> BuscarAnimalesPorNombre(string nombre)
        {
            return (from Animal animal in ObtenerTodosLosAnimales()
                    where animal.Nombre.StartsWith(nombre)
                    select animal).ToList();
        }

        public List<Animal> BuscarAnimalesPorPeriodo(long inicio, long fin)
        {
            return (from Animal animal in ObtenerTodosLosAnimales()
                    where animal.InicioExistenciaEnAños == inicio
                    && animal.FinExistenciaEnAños == fin
                    select animal).ToList();
        }

        private int CantidadDeVisitas(Atraccion atraccion)
        {
            return (from i in ingresosRegistrados
                          where i.AtraccionesVisitadas.Contains(atraccion)
                          select i).Count();
        }

        private List<Animal> ObtenerTodosLosAnimales()
        {
            List<Animal> animales = new List<Animal>();
            foreach(Atraccion atraccion in atracciones)
            {
                animales.AddRange(atraccion.Animales);
            }
            return animales;
        }
    }
}