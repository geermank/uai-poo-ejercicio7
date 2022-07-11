using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Ingreso
    {
        private Persona persona;
        private float importe;
        // guardamos las atracciones visitadas ese dia por si la persona decide cambiar su pasaporte en el futuro
        private List<Atraccion> atraccionesVisitadas; 
        private DateTime fecha;

        public Ingreso(Persona persona, float importe, DateTime fecha, List<Atraccion> atraccionesVisitadas)
        {
            this.persona = persona;
            this.importe = importe;
            this.fecha = fecha;
            this.atraccionesVisitadas = atraccionesVisitadas;
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        public float Importe
        {
            get { return importe; }
        }

        public Persona Persona
        {
            get { return persona; }
        }

        public List<Atraccion> AtraccionesVisitadas
        {
            get { return atraccionesVisitadas; }
        }
    }
}