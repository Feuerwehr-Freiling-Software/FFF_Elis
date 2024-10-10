namespace EPAS.Core.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool PAAvailable { get; set; }
    
    public bool Disabled;
    
    public bool Disponierbar;

    public string PictureRef;

    public int FirebrigadeId { get; set; }
    public Firebrigade Firebrigade { get; set; }

    public DateTime LFKArrive { get; set; }

    public string LFKEinsatzNr { get; set; }

    public DateTime LFKEnroute { get; set; }

    public DateTime LFKFree { get; set; }

    public double LFKLatitude { get; set; }

    public double LFKLongitude { get; set; }

    public string Pumpe { get; set; }

    public int SortNum { get; set; }

    public string StatusFunkUID { get; set; }

    public string StatusInfo { get; set; }

    public DateTime StatusInfoZeit { get; set; }
}