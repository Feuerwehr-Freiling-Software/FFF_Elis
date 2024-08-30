using ELISWCFService;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;

namespace FFF_Elis.Components.Components;

public partial class MapComponent : ComponentBase
{
    [Parameter] public List<Waypoint> Waypoints { get; set; } = new ();
    [Parameter] public List<WCFFahrzeug> Fahrzeuge { get; set; } = new ();
}