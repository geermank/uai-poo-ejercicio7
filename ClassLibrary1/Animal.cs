using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Animal
    {
        protected string nombre;
        protected string lugarDeHabitat;
        protected Dieta dieta;
        protected long inicioExistenciaEnAños;
        protected long finExistenciaEnAños;

        public Animal(string nombre, string lugarDeHabitat, Dieta dieta, long inicioExistenciaEnAños, long finExistenciaEnAños)
        {
            this.nombre = nombre;
            this.lugarDeHabitat = lugarDeHabitat;
            this.dieta = dieta;
            this.inicioExistenciaEnAños = inicioExistenciaEnAños;
            this.finExistenciaEnAños = finExistenciaEnAños;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string LugarDeHabitat
        {
            get { return lugarDeHabitat; }
        }

        public Dieta Dieta
        {
            get { return dieta; }
        }

        public long InicioExistenciaEnAños
        {
            get { return inicioExistenciaEnAños; }
        }

        public long FinExistenciaEnAños
        {
            get { return finExistenciaEnAños; }
        }
    }
}