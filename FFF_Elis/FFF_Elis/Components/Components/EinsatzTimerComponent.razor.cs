using System.Timers;
using ELISWCFService;
using FFF_Elis.ELIS_Services;
using Microsoft.AspNetCore.Components;
using Timer = System.Timers.Timer;
namespace FFF_Elis.Components.Components;

public partial class EinsatzTimerComponent : ComponentBase
{
    [Parameter] public EventCallback<WCFEinsatzdaten> OnNewEinsatz { get; set; }
    [Parameter] public EventCallback OnEinsatzClosed { get; set; }

    public Dictionary<string, bool> EinsatzSent { get; set; } = new();
    
    public WCFEinsatzdaten Einsatz { get; set; }
    
    public ElisClient Client { get; set; } = new ElisClient();
    
    private int _currentIndex = 0;
    
    private Timer _timer;

    protected override void OnInitialized()
    {
        _currentIndex = GetEinsatzCount();
        var open = GetOpenEinsatz();
        if (open.Count > 0)
        {
            Einsatz = open.Last();
            SendNewEinsatz();
        }
        StartTimer();
    }
    
    private void StartTimer()
    {
        _timer = new Timer(2000);
        _timer.Elapsed += OnTimerElapsed;
        _timer.AutoReset = false;
        _timer.Start();
    }

    private async void OnTimerElapsed(object? sender, ElapsedEventArgs e)
    {
        var allEinsatz = (await Client.Client.EinsatzDataGetAllAsync(new EinsatzDataGetAllRequest(Client.Ticket.TicketID))).EinsatzDataGetAllResult;
        if (allEinsatz.Length != 0 && allEinsatz.Length != _currentIndex)
        {
            Einsatz = allEinsatz.Last();
            await InvokeAsync(SendNewEinsatz);
            _currentIndex = allEinsatz.Length;
        }
        else if(allEinsatz.Length == 0 && _currentIndex != 0)
        {
            Console.WriteLine("Einsatz wurde geschlossen");
            _currentIndex = 0;
            await InvokeAsync(CloseEinsatz);
        }
        
        StartTimer();
    }

    private async Task CloseEinsatz()
    {
        await OnEinsatzClosed.InvokeAsync();
    }
    
    private async Task SendNewEinsatz()
    {
        await OnNewEinsatz.InvokeAsync(Einsatz);
    }

    private List<WCFEinsatzdaten> GetOpenEinsatz()
    {
        return Client.Client.EinsatzDataGetAll(new EinsatzDataGetAllRequest(Client.Ticket.TicketID))
            .EinsatzDataGetAllResult.Where(x => x.Status is WCFEinsatzdaten.WCFEinsatzStatus.Alarmiert or WCFEinsatzdaten.WCFEinsatzStatus.Ausgerückt).ToList();
    }
    
    private int GetEinsatzCount()
    {
        return Client.Client.EinsatzDataGetAll(new EinsatzDataGetAllRequest(Client.Ticket.TicketID))
            .EinsatzDataGetAllResult.Length;
    }
    
    public void Dispose()
    {
        _timer?.Dispose();
    }
}