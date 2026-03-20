using System;

namespace PracticaCentralita
{
    public abstract class Llamada
    {
        private string numOrigen;
        private string numDestino;
        private double duracion;

        public string NumOrigen
        {
            get { return numOrigen; }
            set { numOrigen = value; }
        }

        public string NumDestino
        {
            get { return numDestino; }
            set { numDestino = value; }
        }

        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public Llamada(string numOrigen, string numDestino, double duracion)
        {
            this.numOrigen = numOrigen;
            this.numDestino = numDestino;
            this.duracion = duracion;
        }

        public abstract double CalcularPrecio();

        public override string ToString()
        {
            return $"Origen: {NumOrigen} | Destino: {NumDestino} | Duración: {Duracion} seg | Precio: {CalcularPrecio():F2}";
        }
    }
}