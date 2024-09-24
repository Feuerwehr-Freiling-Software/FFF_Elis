using EPAS.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPAS.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class OperationController(IOperationService operationService) : Controller
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetOperation(string id, int firebrigadeId)
    {
        var operation = await operationService.GetOperationAsync(id, firebrigadeId);
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
        var success = await operationService.AddOperationAsync(message.Pdu);
        return success ? Ok() : BadRequest();
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> UpdateOperation([FromBody] Operation operation, string apiKey)
    {
        var success = await operationService.UpdateOperationAsync(operation, apiKey);
        return success ? Ok() : BadRequest();
    }
}