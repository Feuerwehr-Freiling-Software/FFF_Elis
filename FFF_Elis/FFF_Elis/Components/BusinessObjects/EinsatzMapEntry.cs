namespace FFF_Elis.Components.BusinessObjects;

public class EinsatzMapEntry : Waypoint
{
    public string EinsatzTyp { get; set; } = "SONSTIGE";
    public int Alarmstufe { get; set; } = 0;
}