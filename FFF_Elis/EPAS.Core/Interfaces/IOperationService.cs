using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface IOperationService
{
    public Task<Operation?> GetOperationAsync(string id);
    public Task<List<Operation>> GetOperationsAsync(int firebrigadeId);
    public Task<List<Operation>> GetOpenOperationsByFirebrigade(string apikey);
    public Task<EpasResult<bool>> AddOrUpdateOperationAsync(WASMessage message);
    public Task<bool> AddOperationAsync(Order operation);
    public Task<bool> UpdateOperation(Order operation);
    public Task<bool> UpdateOperationAsync(Operation operation, string apiKey);
    public Task<bool> DeleteOperationAsync(string id, string apiKey);
}