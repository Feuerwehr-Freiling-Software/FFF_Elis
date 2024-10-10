using EPAS.BusinessLogic.Services;
using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using Microsoft.AspNetCore.SignalR;
using Serilog.Context;

namespace EPAS.Hubs;

public class OperationHub : Hub<IOperationHub>, IOperationHub
{
    private readonly ILogger<OperationHub> _logger;
    private readonly APIKeyService _apiKeyService;

    public OperationHub(ILogger<OperationHub> logger, APIKeyService apiKeyService)
    {
        _logger = logger;
        _apiKeyService = apiKeyService;
    }
    
    
    public async Task<EpasResult<bool>> RegisterClient(string fireBrigadeName, string apiKey)
    {
        if (!await _apiKeyService.ValidateKey(fireBrigadeName, apiKey))
        {
            _logger.LogInformation("Registering client {FireBrigadeName} failed. API Key invalid.", fireBrigadeName);
            return new EpasResult<bool>("Invalid Api Key", false, EpasResultCode.InvalidApiKey);
        }
        
        using (LogContext.PushProperty("FireBrigade", fireBrigadeName))
        {
            _logger.LogInformation("Registering client {FireBrigadeName} with connection {ConnectionId}", fireBrigadeName, Context.ConnectionId);
        }
        await Groups.AddToGroupAsync(Context.ConnectionId, fireBrigadeName);
        return new EpasResult<bool>("Successfully registered", true, EpasResultCode.NoError);
    }

    public async Task<EpasResult<bool>> NewOperation(string fireBrigadeName, WASMessage operation)
    {
        using (LogContext.PushProperty("FireBrigade", fireBrigadeName))
        {
            if (!await _apiKeyService.ValidateKey(fireBrigadeName, operation.APIKey))
            {
                _logger.LogInformation("Registering client {FireBrigadeName} failed. API Key invalid.", fireBrigadeName);
                return new EpasResult<bool>("Invalid Api Key", false, EpasResultCode.InvalidApiKey);
            }
            
            _logger.LogInformation("New operation received from {FireBrigadeName} with connection {ConnectionId}", fireBrigadeName, Context.ConnectionId);
            
            await Clients.Group(fireBrigadeName).NewOperation(fireBrigadeName, operation);
            return new EpasResult<bool>("Operation sent", true, EpasResultCode.NoError);
        }
    }
}