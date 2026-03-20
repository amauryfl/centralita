using System;

namespace PracticaCentralita
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita();

            centralita.RegistrarLlamada(new LlamadaLocal("809-111-1111", "809-222-2222", 60));
            centralita.RegistrarLlamada(new LlamadaProvincial("809-333-3333", "809-444-4444", 120, 1));
            centralita.RegistrarLlamada(new LlamadaProvincial("809-555-5555", "809-666-6666", 80, 2));
            centralita.RegistrarLlamada(new LlamadaLocal("809-777-7777", "809-888-8888", 30));
            centralita.RegistrarLlamada(new LlamadaProvincial("809-999-9999", "809-000-0000", 45, 3));

            centralita.MostrarLlamadas();
            centralita.MostrarResumen();

            Console.ReadKey();
        }
    }
}