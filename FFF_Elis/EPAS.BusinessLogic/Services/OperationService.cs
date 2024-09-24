using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;

namespace EPAS.BusinessLogic.Services;

public class OperationService : IOperationService
{
    private readonly ApplicationDbContext _dbContext;

    public OperationService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Operation?> GetOperationAsync(string id, int firebrigadeId)
    {
        var res = (await _dbContext.Firebrigades.Include(x => x.Operations).FirstOrDefaultAsync(x => x.Id == firebrigadeId))?.Operations.FirstOrDefault(x => x.Id == id) ?? null;
        return res;
    }

    public async Task<List<Operation>> GetOperationsAsync(int firebrigadeId)
    {
        var res = (await _dbContext.Firebrigades.Include(x => x.Operations).FirstOrDefaultAsync(x => x.Id == firebrigadeId))?.Operations.ToList() ?? new List<Operation>();
        return res;
    }

    public async Task<bool> AddOperationAsync(Pdu pdu)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateOperationAsync(Operation operation, string apiKey)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteOperationAsync(string id, string apiKey)
    {
        throw new NotImplementedException();
    }
}