using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface IOperationService
{
    public Task<Operation?> GetOperationAsync(string id);
    public Task<List<Operation>> GetOperationsAsync(int firebrigadeId);
    public Task<List<Operation>> GetOpenOperationsByFirebrigade(string apikey);
    public Task<EpasResult<bool>> AddOrUpdateOperationAsync(WASMessage message);
    public Task<EpasResult<Operation>> AddOperationAsync(Order operation);
    public Task<bool> UpdateOperationAsync(Order operation);
    public Task<bool> UpdateOperationAsync(Operation operation, string apiKey);
    public Task<bool> DeleteOperationAsync(string id, string apiKey);
    public Task<bool> AddOperationResponseAsync(OperationResponse operationResponse);
    public Task<bool> UpdateOperationResponseAsync(OperationResponse operationResponse);
    public Task<bool> DeleteOperationResponseAsync(string id);
    public Task<bool> AddOperationNameAsync(OperationName operationName);
    public Task<EpasResult<OperationName>> AddOperationNameAsync(string operationName);
    public Task<bool> FinishAllOperationsAsync(string operationApiKey);
}