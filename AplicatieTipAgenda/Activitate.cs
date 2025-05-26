using System;

namespace AplicatieTipAgenda
{
    public class Activitate
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public string Tip { get; set; }

        public Activitate(string titlu, string descriere, DateTime data, string tip)
        {
            Titlu = titlu;
            Descriere = descriere;
            Data = data;
            Tip = tip;
        }

        public override string ToString()
        {
            return $"{Titlu} | {Data:yyyy-MM-dd HH:mm} | {Tip} | {Descriere}";
        }
    }
}
