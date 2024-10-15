using System.Timers;
using Blazored.LocalStorage;
using EPAS.BusinessLogic.Dtos;
using EPAS.BusinessLogic.Services;
using EPAS.Core.BusinessObjects;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Timer = System.Timers.Timer;

namespace EPAS.Components.Components;

public partial class EinsatzTimerComponent : ComponentBase
{
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Inject] public ILocalStorageService LocalStorageService { get; set; }
    [Parameter] public EventCallback<OperationDto> OnNewEinsatz { get; set; }
    [EditorRequired, Parameter] public EventCallback<List<OperationDto>> OnOperationUpdate { get; set; }

    public List<OperationDto> Operations { get; set; } = new();
    
    private int _currentIndex = 0;
    
    private Timer _timer;

    private HubConnection _connection;
    private OperationHubProxy Client;
    private ClientSettings _settings = new();
    private string ApiKey = string.Empty;
    private string FirebrigadeName = string.Empty;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        _connection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/operationHub"))
            .WithAutomaticReconnect()
            .Build();
        
        _settings = await LocalStorageService.GetItemAsync<ClientSettings>("ClientSettings") ?? new ClientSettings();
        
        _connection.On("OperationUpdate", async (List<OperationDto> operation) => await UpdateOperation(operation));
        
        await _connection.StartAsync();
        Client = new OperationHubProxy(_connection, _settings.ApiKey, _settings.FirebrigadeName);
        await Client.RegisterClient();
    }

    private async Task UpdateOperation(List<OperationDto> operation)
    {
        if (operation.Any())
        {
            foreach (var op in operation)
            {
                var existing = Operations.FirstOrDefault(x => x.OperationId == op.OperationId);
                if (existing != null)
                {
                    Operations.Remove(existing);
                }
                Operations.Add(op);
            }
        }
        else
        {
            Operations = [];
        }
        
        await OnOperationUpdate.InvokeAsync(Operations);
        await InvokeAsync(StateHasChanged);
    }
    
    public void Dispose()
    {
        _timer?.Dispose();
    }
}