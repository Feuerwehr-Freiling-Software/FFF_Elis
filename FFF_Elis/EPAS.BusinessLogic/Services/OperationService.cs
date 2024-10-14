using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
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
    
    public async Task<Operation?> GetOperationAsync(string id)
    {
        var res = await _dbContext.Operations.Include(x => x.Firebrigades)
            .Include(operation => operation.OperationResponses).ThenInclude(operationResponse => operationResponse.User)
            .ThenInclude(applicationUser => applicationUser.Firebrigades).FirstOrDefaultAsync(x => x.Id == id);
        return res;
    }

    public async Task<List<Operation>> GetOperationsAsync(int firebrigadeId)
    {
        var res = (await _dbContext.Firebrigades.Include(x => x.Operations).FirstOrDefaultAsync(x => x.Id == firebrigadeId))?.Operations.ToList() ?? new List<Operation>();
        return res;
    }

    public async Task<List<Operation>> GetOpenOperationsByFirebrigade(string apiKey)
    {
        var res = (await _dbContext.Applications.Include(x => x.Firebrigade)
            .ThenInclude(firebrigade => firebrigade.Operations).FirstOrDefaultAsync(x => x.ApiKey == apiKey))?.Firebrigade.Operations.Where(x => x.Completed == null).ToList() ?? new List<Operation>();
        return res;
    }

    public async Task<EpasResult<bool>> AddOrUpdateOperationAsync(WASMessage message)
    {
        foreach (var operation in message.Pdu.Orderlist.Order)
        {
            var res = await GetOperationAsync(operation.Operationid);
            if (res != null)
            {
                await UpdateOperationAsync(res, message.APIKey);
            }
            else
            {
                await AddOperationAsync(operation);
            }
        }
        
        return new EpasResult<bool>("Operation added", true, EpasResultCode.NoError);
    }

    public async Task<bool> AddOperationAsync(Order order)
    {
        var originId = await _dbContext.Origins.FirstOrDefaultAsync(x => x.Id == order.WasOrigin.Tid);
        if (originId == null)
        {
            // TODO: Add adding new origin
            return false;
        }
        
        var program = await _dbContext.Programs.FirstOrDefaultAsync(x => x.Name == order.Program);
        if (program == null)
        {
            // TODO: Add adding new program
            return false;
        }
        
        var caller = await _dbContext.Callers.FirstOrDefaultAsync(x => x.Name == order.Caller);
        if (caller == null)
        {
            // TODO: Add adding new caller
            return false;
        }
        
        var operationName = await _dbContext.OperationNames.FirstOrDefaultAsync(x => x.Name == order.Operationname);
        if (operationName == null)
        {
            // TODO: Add adding new operation name
            return false;
        }
        
        var operation = new Operation
        {
            Id = order.Operationid,
            OriginId = originId.Id,
            ProgramId = program.Id,
            CallerId = caller.Id,
            OperationNameId = operationName.Id,
            Recieved = DateTime.Parse(order.Receivetad),
            WatchOut = DateTime.Parse(order.Watchouttad),
            Completed = null,
            Level = order.Level,
            Info = order.Info,
            Adress = order.Destinationlist.Destination.First().Text,
        };
        
        await _dbContext.Operations.AddAsync(operation);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateOperation(Order order)
    {
        var fOperation = await _dbContext.Operations.FirstOrDefaultAsync(x => x.Id == order.Operationid);
        if (fOperation == null)
        {
            await AddOperationAsync(order);
        }
        fOperation = await _dbContext.Operations.FirstOrDefaultAsync(x => x.Id == order.Operationid);
        
        var originId = await _dbContext.Origins.FirstOrDefaultAsync(x => x.Id == order.WasOrigin.Tid);
        if (originId == null)
        {
            // TODO: Add adding new origin
            return false;
        }
        
        var program = await _dbContext.Programs.FirstOrDefaultAsync(x => x.Name == order.Program);
        if (program == null)
        {
            // TODO: Add adding new program
            return false;
        }
        
        var caller = await _dbContext.Callers.FirstOrDefaultAsync(x => x.Name == order.Caller);
        if (caller == null)
        {
            // TODO: Add adding new caller
            return false;
        }
        
        var operationName = await _dbContext.OperationNames.FirstOrDefaultAsync(x => x.Name == order.Operationname);
        if (operationName == null)
        {
            // TODO: Add adding new operation name
            return false;
        }
        
        fOperation.OriginId = originId.Id;
        fOperation.ProgramId = program.Id;
        fOperation.CallerId = caller.Id;
        fOperation.OperationNameId = operationName.Id;
        fOperation.Recieved = DateTime.Parse(order.Receivetad);
        fOperation.WatchOut = DateTime.Parse(order.Watchouttad);
        fOperation.Level = order.Level;
        fOperation.Info = order.Info;
        fOperation.Adress = order.Destinationlist.Destination.First().Text;
        
        _dbContext.Operations.Update(fOperation);
        var res = await _dbContext.SaveChangesAsync();
        return res > 0;
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