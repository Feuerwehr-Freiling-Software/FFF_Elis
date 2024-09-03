using ELISWCFService;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace FFF_Elis.Components.Components;

public partial class MapComponent : ComponentBase
{
    [Parameter] public List<Waypoint> Waypoints { get; set; } = new ();
    [Parameter] public List<WCFFahrzeug> Fahrzeuge { get; set; } = new ();

    protected override async Task OnParametersSetAsync()
    {
        await Task.CompletedTask;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await AddRouteAsync(Waypoints);
    }

    private async Task AddRouteAsync(List<Waypoint> waypoints)
    {
        await JS.InvokeVoidAsync("addRoute", waypoints);
    }
}