using System;

namespace ClassLibrary1
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;

        public Persona(string nombre, string apellido, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public String Apellido
        {
            get { return apellido; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
        }

        public int EdadEnAños
        {
            get
            {
                int años = DateTime.Now.Year - fechaDeNacimiento.Year;
                if (DateTime.Now.Day > fechaDeNacimiento.Day && DateTime.Now.Month >= fechaDeNacimiento.Month)
                {
                    // todavia no cumplio años este año
                    años--;
                }
                return años;
            }
        }
    }
}