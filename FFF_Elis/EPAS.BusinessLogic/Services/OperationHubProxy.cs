﻿using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace EPAS.BusinessLogic.Services;

public class OperationHubProxy(HubConnection connection, string apiKey, string fireBrigadeName)
{
    public async Task<EpasResult<bool>> RegisterClient()
    {
        return await connection.InvokeAsync<EpasResult<bool>>("RegisterClient", fireBrigadeName, apiKey);
    }

    public async Task<EpasResult<bool>> NewOperation(WASMessage operation)
    {
        operation.APIKey = apiKey;
        var res = await connection.InvokeAsync<EpasResult<bool>>(methodName: "newoperation", arg1: fireBrigadeName, arg2: operation);

        return res;
    }
}