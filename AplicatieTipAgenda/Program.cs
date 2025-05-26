using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;


namespace AplicatieTipAgenda
{
    class Program
    {
        static void Main()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string caleCompletaFisier = Path.Combine(Directory.GetCurrentDirectory(), "activitati.txt");

            Agenda agenda = new Agenda();
            AdminActivitate adminActivitate = new AdminActivitate();

            Console.WriteLine("Bine ai venit în aplicatia de agendă!");

            while (true)
            {
                Console.WriteLine("\nMeniu:");
                Console.WriteLine("1. Adaugă activitate");
                Console.WriteLine("2. Salvare in fisier");
                Console.WriteLine("0. Iesire");
                Console.Write("Alege o optiune: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        Console.Write("Titlu: ");
                        string titlu = Console.ReadLine();
                        Console.Write("Descriere: ");
                        string descriere = Console.ReadLine();
                        Console.Write("Data (yyyy-mm-dd hh:mm): ");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        Console.Write("Tip activitate: ");
                        string tip = Console.ReadLine();

                        
                        agenda.AdaugaActivitate(new Activitate(titlu, descriere, data, tip));
                        break;

                    case "2":
                        GestionareDate gestionare = new GestionareDate(caleCompletaFisier); // ← inițializare aici
                        var lista = agenda.GetActivitati();
                        gestionare.SalveazaActivitati(lista);
                        Console.WriteLine("Activitățile au fost salvate cu succes!");
                        break;


                        break;

                    case "0":
                        Console.WriteLine("La revedere!");
                        return;

                    default:
                        Console.WriteLine("Optiune invalidă! Încearcă din nou.");
                        break;
                }
            }
        }
    }
}
