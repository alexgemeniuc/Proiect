using System;

namespace AplicatieTipAgenda
{
    public class Activitate
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public string TipActivitate { get; set; }

        public Activitate(string titlu, string descriere, DateTime data, string tipActivitate)
        {
            Titlu = titlu;
            Descriere = descriere;
            Data = data;
            TipActivitate = tipActivitate;
        }

        public override string ToString()
        {
            return $"[{Data:dd/MM/yyyy HH:mm}] {Titlu} - {TipActivitate}: {Descriere}";
        }
    }
}
