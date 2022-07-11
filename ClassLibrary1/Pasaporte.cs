using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Pasaporte
    {
        private Persona persona;
        private List<Atraccion> atracciones;

        public Pasaporte(Persona persona, List<Atraccion> atracciones)
        {
            this.persona = persona;
            this.atracciones = atracciones;
        }

        public float CalcularPrecio()
        {
            float precio = CalcularPrecioDeLasAtracciones();
            return AplicarDescuentoPorEdad(precio);
        }

        public Ingreso RegistrarIngreso(DateTime fechaDeIngreso)
        {
            return new Ingreso(persona, CalcularPrecio(), fechaDeIngreso, atracciones);
        }

        private float CalcularPrecioDeLasAtracciones()
        {
            float precio = atracciones.Sum(a => a.Precio);
            if (atracciones.Count == 2)
            {
                precio -= (precio * 10) / 100;
            }
            else if (atracciones.Count == 3)
            {
                precio -= (precio * 30) / 100;
            }
            return precio;
        }

        private float AplicarDescuentoPorEdad(float precioBase)
        {
            float precio = precioBase;
            if (persona.EdadEnAños > 65 || persona.EdadEnAños < 12)
            {
                precio -= (precio * 50) / 100;
            }
            return precio;
        }
    }
}