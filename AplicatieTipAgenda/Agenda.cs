using System.Collections.Generic;

namespace AplicatieTipAgenda
{
    public class Agenda
    {
        private List<Activitate> activitati = new List<Activitate>();

        public void AdaugaActivitate(Activitate a)
        {
            activitati.Add(a);
        }

        public List<Activitate> GetActivitati()
        {
            return activitati;
        }
    }
}
