using System;

namespace PracticaCentralita
{
    public class LlamadaLocal : Llamada
    {
        private const double PRECIO = 0.15;

        public LlamadaLocal(string numOrigen, string numDestino, double duracion)
            : base(numOrigen, numDestino, duracion)
        {
        }

        public override double CalcularPrecio()
        {
            return Duracion * PRECIO;
        }

        public override string ToString()
        {
            return "[Local] " + base.ToString();
        }
    }
}