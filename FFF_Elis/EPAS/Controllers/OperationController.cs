using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPAS.Controllers;

[ApiController, AllowAnonymous]
[Route("api/[controller]/[action]")]
public class OperationController(Logger<OperationController> logger,IOperationService operationService, IFirebrigadeService firebrigadeService) : Controller
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