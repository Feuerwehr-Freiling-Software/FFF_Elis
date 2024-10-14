using EPAS.BusinessLogic.Services;
using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using Microsoft.AspNetCore.SignalR;
using Serilog;
using Serilog.Context;

namespace EPAS.Hubs;

public class OperationHub(ILogger<OperationHub> logger, IAPIKeyService apiKeyService, IOperationService operationService) : Hub
{
    
    public async Task<EpasResult<bool>> RegisterClient(string fireBrigadeName, string apiKey)
    {
        if (!await apiKeyService.ValidateKey(fireBrigadeName, apiKey))
        {
            logger.LogInformation("Registering client {FireBrigadeName} failed. API Key invalid.", fireBrigadeName);
            return new EpasResult<bool>("Invalid Api Key", false, EpasResultCode.InvalidApiKey);
        }
        
        using (LogContext.PushProperty("FireBrigade", fireBrigadeName))
        {
            logger.LogInformation("Registering client {FireBrigadeName} with connection {ConnectionId}", fireBrigadeName, Context.ConnectionId);
        }
        await Groups.AddToGroupAsync(Context.ConnectionId, fireBrigadeName);
        return new EpasResult<bool>("Successfully registered", true, EpasResultCode.NoError);
    }

    public async Task<EpasResult<bool>> NewOperation(string fireBrigadeName, WASMessage operation)
    {
        logger.LogInformation("Did something");
        using (LogContext.PushProperty("FireBrigade", fireBrigadeName))
        {
            if (!await apiKeyService.ValidateKey(fireBrigadeName, operation.APIKey))
            {
                logger.LogInformation("Registering client {FireBrigadeName} failed. API Key invalid.", fireBrigadeName);
                return new EpasResult<bool>("Invalid Api Key", false, EpasResultCode.InvalidApiKey);
            }
            
            logger.LogInformation("New operation received from {FireBrigadeName} with connection {ConnectionId}", fireBrigadeName, Context.ConnectionId);
            
            var res = await operationService.AddOrUpdateOperationAsync(operation);
            if (res.ResultCode != EpasResultCode.NoError)
            {
                logger.LogError("Failed to add operation {OperationId}", operation.Pdu.Xsd);
                return new EpasResult<bool>("Failed to add operation", false, EpasResultCode.CouldntAddOperation);
            }
            else
            {
                await Clients.Group(fireBrigadeName).SendAsync("OperationUpdate", operation);
                logger.LogInformation("Operation {OperationId} added", operation.Pdu.Xsd);
                return new EpasResult<bool>("Operation sent", true, EpasResultCode.NoError);
            }
            
        }
    }
}