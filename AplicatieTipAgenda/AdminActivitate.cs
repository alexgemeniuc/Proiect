using System;
using AplicatieTipAgenda;
using System.Collections.Generic;


public class AdminActivitate
{
    private List<Activitate> activitati = new List<Activitate>();
    public void addActivitate(string titlu, string descriere, DateTime data, string locatie)
    {
        // Logica pentru adăugarea unei activități
        Activitate activitate = new Activitate(titlu, descriere, data, locatie);
        activitati.Add(activitate);
    }
    public List <Activitate> getActivitati()
	{
        return activitati;
    }
}
