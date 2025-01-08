using EPAS.BusinessLogic.Services;
using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace EPAS.Components.Pages.Operation;

public partial class OperationInfo : ComponentBase
{
    [Parameter] public string Id { get; set; } = "";
    [Inject] public IOperationService OperationService { get; set; } = null!;
    [Inject] public GeocodingService GeoCoding { get; set; } = null!;
    public Core.Models.Operation Operation { get; set; } = new();
    public List<Waypoint> Waypoints { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        Operation = await OperationService.GetOperationAsync(Id) ?? new();
        var waypoint = await GeoCoding.GetWaypointAsync(Operation.Adress);
        if (waypoint != null)
        {
            Waypoints.Add(waypoint);
        }
    }
}