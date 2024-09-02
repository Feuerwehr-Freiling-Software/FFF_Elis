using System.Timers;
using ELISWCFService;
using FFF_Elis.ELIS_Services;
using Microsoft.AspNetCore.Components;
using Timer = System.Timers.Timer;
namespace FFF_Elis.Components.Components;

public partial class EinsatzTimerComponent : ComponentBase
{
    [Parameter] public EventCallback<WCFEinsatzdaten> OnNewEinsatz { get; set; }

    public ElisClient Client { get; set; } = new ElisClient();
    
    private int _currentIndex = 0;
    
    private Timer _timer;

    protected override void OnInitialized()
    {
        _currentIndex = GetEinsatzCount();
        StartTimer();
    }
    
    private void StartTimer()
    {
        _timer = new Timer(20000);
        _timer.Elapsed += OnTimerElapsed;
        _timer.AutoReset = false;
        _timer.Start();
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        var einsatzCount = GetEinsatzCount();
        if (_currentIndex != einsatzCount)
        {
            var einsatzdata = Client.Client.EinsatzDataGetAll(new EinsatzDataGetAllRequest(Client.Ticket.TicketID))
                .EinsatzDataGetAllResult;
            
            OnNewEinsatz.InvokeAsync(einsatzdata[^1]);
            _currentIndex = einsatzCount;
            InvokeAsync(StateHasChanged);
        }
        StartTimer();
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