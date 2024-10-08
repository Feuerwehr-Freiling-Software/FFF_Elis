using Microsoft.AspNetCore.SignalR;
using Serilog.Context;

namespace EPAS.Hubs;

public class OperationHub : Hub
{
    private readonly ILogger<OperationHub> _logger;

    public OperationHub(ILogger<OperationHub> logger)
    {
        _logger = logger;
    }
    
    
    public async Task RegisterClient(string fireBrigadeName)
    {
        using (LogContext.PushProperty("FireBrigade", fireBrigadeName))
        {
            _logger.LogInformation("Registering client {FireBrigadeName} with connection {ConnectionId}", fireBrigadeName, Context.ConnectionId);
        }
        await Groups.AddToGroupAsync(Context.ConnectionId, fireBrigadeName);
    }
}