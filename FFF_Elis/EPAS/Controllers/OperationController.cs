using EPAS.BusinessLogic.Services;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPAS.Controllers;

[ApiController, AllowAnonymous]
[Route("api/[controller]/[action]")]
public class OperationController(ILogger<OperationController> logger,IOperationService operationService, IFirebrigadeService firebrigadeService, IAPIKeyService apiKeyService) : Controller
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetOperation(string id)
    {
        var operation = await operationService.GetOperationAsync(id);
        return operation == null ? NotFound() : Ok(operation);
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetOperations(int firebrigadeId)
    {
        var operations = await operationService.GetOperationsAsync(firebrigadeId);
        return Ok(operations);
    }
    
    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> GetOperationsWithKey(string firebrigade, string apiKey)
    {
        bool validApiKey = await apiKeyService.ValidateKey(fireBrigadeName:firebrigade, key: apiKey);
        var firebrigadeId = await firebrigadeService.GetFirebrigadeAsync(firebrigade);
        var operations = await operationService.GetOperationsAsync(firebrigadeId.Result.Id);
        return Ok(operations);
    }

    [HttpPost]
    public async Task<IActionResult> AddOperation(WASMessage message)
    {
        // var success = await operationService.AddOperationAsync(message.Pdu);
        logger.LogInformation("Invoked Empty AddOperation Endpoint");
        return Ok();
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> UpdateOperation([FromBody] Operation operation, string apiKey)
    {
        var success = await operationService.UpdateOperationAsync(operation, apiKey);
        return success ? Ok() : BadRequest();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetOpenOperations(string apiKey)
    {
        var operations = await operationService.GetOpenOperationsByFirebrigade(apiKey);
        return Ok(operations);
    }
    
    [HttpGet]
    public async Task<IActionResult> AddOrUpdateOperation(WASMessage message)
    {
        
        
        return Ok();
    }
}