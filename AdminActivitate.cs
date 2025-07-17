using System.Collections.Generic;
using System.Linq;

public class AdminActivitate
{
    private List<Activitate> activitati = new List<Activitate>();

    public void Adauga(Activitate act)
    {
        activitati.Add(act);
    }

    public List<Activitate> GetAll()
    {
        return activitati;
    }

    public List<Activitate> Cauta(string titlu)
    {
        return activitati
            .Where(a => a.Titlu.ToLower().Contains(titlu.ToLower()))
            .ToList();
    }
}
