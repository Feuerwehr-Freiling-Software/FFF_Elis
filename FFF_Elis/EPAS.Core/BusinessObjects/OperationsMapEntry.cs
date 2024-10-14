namespace EPAS.Core.BusinessObjects;

public class OperationsMapEntry : Waypoint
{
    public string EinsatzTyp { get; set; } = "SONSTIGE";
    public int Alarmstufe { get; set; } = 0;
}