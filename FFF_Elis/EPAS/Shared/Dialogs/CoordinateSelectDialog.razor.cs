using System.Globalization;
using EPAS.Core.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace EPAS.Shared.Dialogs;

public partial class CoordinateSelectDialog : ComponentBase
{
    private bool _isDialogOpen = true;
    [CascadingParameter] public MudDialogInstance MudDialog { get; set; } = null!;

    [Inject] public IJSRuntime JSRuntime { get; set; } = null!;
    [Inject] public ISnackbar Snackbar { get; set; } = null!;
    
    [Parameter] public Waypoint CurrentCoordinates { get; set; } = new Waypoint();

    /// <summary>
    /// Gets or sets the message to be displayed in the dialog.
    /// </summary>
    [Parameter]
    public string Message { get; set; } = string.Empty;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("AddHouseToMap", CurrentCoordinates.lat, CurrentCoordinates.lon);
        }
    }

    public async Task Submit()
    {
        var newCoordinates = await GetCoordinatesFromMap();

        if (newCoordinates == new Waypoint())
        {
            Snackbar.Add("Keine gültigen Koordinaten ausgewählt.", Severity.Error);
        }
        
        await InvokeAsync(StateHasChanged);
        MudDialog.Close(DialogResult.Ok(newCoordinates));
    }

    private async Task<Waypoint> GetCoordinatesFromMap()
    {
        var result = await JSRuntime.InvokeAsync<string>("getCoordinates");
        string[] coordinates;
        try
        {
            coordinates = result.Split('(')[1].Split(')')[0].Split(',');
        }
        catch (Exception e)
        {
            return new Waypoint();
        }
        
        return new Waypoint
        {
            lat = float.Parse(coordinates[0].Trim(), CultureInfo.InvariantCulture),
            lon = float.Parse(coordinates[1].Trim(), CultureInfo.InvariantCulture)
        };
    }

    public async Task Cancel()
    {
        _isDialogOpen = false;
        MudDialog.StateHasChanged();
        MudDialog.Dispose();
        await InvokeAsync(StateHasChanged);
        MudDialog.Cancel();
    }
}