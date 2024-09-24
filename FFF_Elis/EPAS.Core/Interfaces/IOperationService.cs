namespace EPAS.Core.Models;

public interface IOperationService
{
    public Task<Operation?> GetOperationAsync(string id, int firebrigadeId);
    public Task<List<Operation>> GetOperationsAsync(int firebrigadeId);
    public Task<bool> AddOperationAsync(Pdu operation);
    public Task<bool> UpdateOperationAsync(Operation operation, string apiKey);
    public Task<bool> DeleteOperationAsync(string id, string apiKey);
}