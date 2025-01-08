using Blazored.LocalStorage;
using EPAS.BusinessLogic.Services;
using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using Microsoft.AspNetCore.Components;

namespace EPAS.Components.Pages;

public partial class OperationHistory : ComponentBase
{
    [Inject] public IOperationService OperationService { get; set; } = default!;
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = default!;
    public ClientSettings Settings { get; set; } = new ClientSettings();
    public List<Core.Models.Operation> Operations { get; set; } = new ();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Settings = await GetClientSettings();
            Operations = await OperationService.GetOperationsByKeyAsync(Settings.ApiKey);
            StateHasChanged();
        }
    }

    private async Task<ClientSettings> GetClientSettings()
    {
        var res = await LocalStorageService.GetItemAsync<ClientSettings>("ClientSettings");
        if (res == null)
        {
            res = new ClientSettings();
        }
        
        return res;
    }
}