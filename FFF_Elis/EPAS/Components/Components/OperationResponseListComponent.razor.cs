using Blazored.LocalStorage;
using EPAS.BusinessLogic.Dtos;
using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;
using Microsoft.AspNetCore.Components;

namespace EPAS.Components.Components;

public partial class OperationResponseListComponent : ComponentBase
{
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = null!;
    [Parameter] public List<OperationResponseDto> Responses { get; set; }

    public ClientSettings Settings { get; set; } = new ClientSettings();
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Settings = await LocalStorageService.GetItemAsync<ClientSettings>("ClientSettings") ?? new ClientSettings();
        }
    }

    protected override void OnParametersSet()
    {
        Responses = Responses.OrderBy(r => r.Response).ToList();
    }
}