using System;
using System.Collections.Generic;
using System.Linq;

namespace AplicatieTipAgenda
{
    public class Agenda
    {
        private List<Activitate> activitati;

        public Agenda()
        {
            activitati = new List<Activitate>();
        }

        public void AdaugaActivitate(Activitate activitate)
        {
            activitati.Add(activitate);
        }

        public void StergeActivitate(string titlu)
        {
            activitati.RemoveAll(a => a.Titlu.Equals(titlu, StringComparison.OrdinalIgnoreCase));
        }

        public void AfiseazaActivitatiDinZi(DateTime data)
        {
            var activitatiDinZi = activitati.Where(a => a.Data.Date == data.Date).ToList();
            if (activitatiDinZi.Count == 0)
            {
                Console.WriteLine("Nu există activități pentru această zi.");
                return;
            }
            activitatiDinZi.ForEach(Console.WriteLine);
        }

        public void AfiseazaActivitatiDupaTip(string tip)
        {
            var activitatiTip = activitati.Where(a => a.TipActivitate.Equals(tip, StringComparison.OrdinalIgnoreCase)).ToList();
            if (activitatiTip.Count == 0)
            {
                Console.WriteLine($"Nu există activități de tipul \"{tip}\".");
                return;
            }
            activitatiTip.ForEach(Console.WriteLine);
        }

        public void AfiseazaActivitatiRepetate()
        {
            var grupate = activitati.GroupBy(a => a.Titlu)
                                    .Where(g => g.Count() > 1)
                                    .ToList();

            if (grupate.Count == 0)
            {
                Console.WriteLine("Nu există activități repetate.");
                return;
            }

            foreach (var grup in grupate)
            {
                Console.WriteLine($"Activitatea \"{grup.Key}\" apare de {grup.Count()} ori:");
                foreach (var act in grup)
                    Console.WriteLine($"\t{act}");
            }
        }
    }
}
