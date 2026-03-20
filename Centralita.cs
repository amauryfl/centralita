using System;
using System.Collections.Generic;

namespace PracticaCentralita
{
    public class Centralita
    {
        private int totalLlamadas;
        private double totalFacturado;
        private List<Llamada> listaLlamadas;

        public Centralita()
        {
            totalLlamadas = 0;
            totalFacturado = 0;
            listaLlamadas = new List<Llamada>();
        }

        public void RegistrarLlamada(Llamada llamada)
        {
            listaLlamadas.Add(llamada);
            totalLlamadas++;
            totalFacturado += llamada.CalcularPrecio();
        }

        public void MostrarLlamadas()
        {
            foreach (var llamada in listaLlamadas)
            {
                Console.WriteLine(llamada);
            }
        }

        public void MostrarResumen()
        {
            Console.WriteLine("\nTotal llamadas: " + totalLlamadas);
            Console.WriteLine("Total facturado: " + totalFacturado.ToString("F2"));
        }
    }
}