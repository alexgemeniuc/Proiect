using System;
using System.Collections.Generic;
using System.IO;
using Agenda;

namespace Agenda
{
    public class GestionareDate
    {
        private string caleFisier;

        public GestionareDate(string caleFisier)
        {
            this.caleFisier = caleFisier;
        }

        public void SalveazaActivitati(List<Activitate> activitati)
        {
            using (StreamWriter sw = new StreamWriter(caleFisier, false))
            {
                foreach (var activitate in activitati)
                {
                    sw.WriteLine($"{activitate.Titlu};{activitate.Descriere};{activitate.Data};{activitate.Tip}");
                }
            }
        }
    }
}
