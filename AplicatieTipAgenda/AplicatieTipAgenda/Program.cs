using System;

namespace AplicatieTipAgenda
{
    class Program
    {
        static void Main()
        {
            Agenda agenda = new Agenda();
            Console.WriteLine("Bine ai venit în aplicatia de agendă!");

            while (true)
            {
                Console.WriteLine("\nMeniu:");
                Console.WriteLine("1. Adaugă activitate");
                Console.WriteLine("2. Afisează activitătile dintr-o zi");
                Console.WriteLine("3. Afisează activitătile de un anumit tip");
                Console.WriteLine("4. Afisează activitătile repetate");
                Console.WriteLine("5. Iesire");
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
                        Console.WriteLine("Activitate adăugată!");
                        break;

                    case "2":
                        Console.Write("Introdu data (yyyy-mm-dd): ");
                        DateTime dataCautata = DateTime.Parse(Console.ReadLine());
                        agenda.AfiseazaActivitatiDinZi(dataCautata);
                        break;

                    case "3":
                        Console.Write("Introdu tipul activitătii: ");
                        string tipCautat = Console.ReadLine();
                        agenda.AfiseazaActivitatiDupaTip(tipCautat);
                        break;

                    case "4":
                        agenda.AfiseazaActivitatiRepetate();
                        break;

                    case "5":
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
