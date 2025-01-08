using Microsoft.AspNetCore.Components;

namespace EPAS.Components.Components.Operation;

public partial class HistoryCardComponent : ComponentBase
{
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Parameter] public Core.Models.Operation Operation { get; set; } = null!;

    private void OpenOperationHistoryInfo()
    {
        NavigationManager.NavigateTo($"/operationInfo/{Operation.Id}");
    }
}