using System.Timers;
using FFF_Elis.Components.BusinessObjects;
using Microsoft.AspNetCore.Components;
using Timer = System.Timers.Timer;

namespace FFF_Elis.Components.Components;

public partial class VisualItemComponent : ComponentBase
{
    [Parameter] public List<VisualItem> Items { get; set; }
    private VisualItem _currentVisualItem;
    private int _currentIndex = 0;
    private Timer _timer;

    protected override void OnInitialized()
    {
        if (Items != null && Items.Count > 0)
        {
            _currentVisualItem = Items[_currentIndex];
            StartTimer();
        }
    }

    private void StartTimer()
    {
        _timer = new Timer(_currentVisualItem.Duration * 1000);
        _timer.Elapsed += OnTimerElapsed;
        _timer.AutoReset = false;
        _timer.Start();
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        _currentIndex = (_currentIndex + 1) % Items.Count;
        _currentVisualItem = Items[_currentIndex];
        InvokeAsync(StateHasChanged);
        StartTimer();
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}