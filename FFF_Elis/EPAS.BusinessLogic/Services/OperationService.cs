using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;

namespace EPAS.BusinessLogic.Services;

public class OperationService(ApplicationDbContext dbContext, IOriginService originService, IProgramService programService, ICallerService callerService, IFirebrigadeService firebrigadeService)
    : IOperationService
{

    public async Task<Operation?> GetOperationAsync(string id)
    {
        var res = await dbContext.Operations.Include(x => x.Firebrigades)
            .Include(operation => operation.OperationResponses).ThenInclude(operationResponse => operationResponse.User)
            .ThenInclude(applicationUser => applicationUser.Firebrigades).FirstOrDefaultAsync(x => x.Id == id);
        return res;
    }

    public async Task<List<Operation>> GetOperationsAsync(int firebrigadeId)
    {
        var res = (await dbContext.Firebrigades.Include(x => x.Operations).FirstOrDefaultAsync(x => x.Id == firebrigadeId))?.Operations.ToList() ?? new List<Operation>();
        return res;
    }

    public async Task<List<Operation>> GetOpenOperationsByFirebrigade(string apiKey)
    {
        var tmp = (await dbContext.Applications
                .Include(x => x.Firebrigade)
                .ThenInclude(firebrigade => firebrigade.Operations)
                .ThenInclude(x => x.OperationResponses)
                .ThenInclude(x => x.User)
                .ThenInclude(x => x.Qualifications)
                .FirstOrDefaultAsync(x => x.ApiKey == apiKey))?.Firebrigade;
        
        var res = (await dbContext.Applications
            .Include(x => x.Firebrigade)
            .ThenInclude(firebrigade => firebrigade.Operations)
            .ThenInclude(x => x.OperationResponses)
            .ThenInclude(x => x.User)
            .ThenInclude(x => x.Qualifications)
            .FirstOrDefaultAsync(x => x.ApiKey == apiKey))?
            .Firebrigade.Operations.Where(x => x.Completed == null)
            .ToList() ?? new List<Operation>();
        return res;
    }

    public async Task<EpasResult<bool>> AddOrUpdateOperationAsync(WASMessage message)
    {
        foreach (var operation in message.Pdu.Orderlist.Order)
        {
            var res = await GetOperationAsync(operation.Operationid);
            if (res != null)
            {
                var updated = await UpdateOperationAsync(operation);
            }
            else
            {
                var result = await AddOperationAsync(operation);
            }
        }
        
        return new EpasResult<bool>("Operation added", true, EpasResultCode.NoError);
    }

    public async Task<EpasResult<Operation>> AddOperationAsync(Order order)
    {
        var originId = await dbContext.Origins.FirstOrDefaultAsync(x => x.Id == order.WasOrigin.Tid) ?? await originService.AddOriginAsync(order.WasOrigin);

        var program = await dbContext.Programs.FirstOrDefaultAsync(x => x.Name == order.Program) ?? await programService.AddProgramAsync(order);
        
        var caller = await dbContext.Callers.FirstOrDefaultAsync(x => x.Name == order.Caller) ?? (await callerService.AddCallerAsync(new Caller(){Name = order.Caller})).Result;
        
        var operationName = await dbContext.OperationNames.FirstOrDefaultAsync(x => x.Name == order.Operationname) ?? (await AddOperationNameAsync(order.Operationname)).Result;
        
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
        
        var res = await dbContext.Operations.AddAsync(operation);
        await dbContext.SaveChangesAsync();
        return new EpasResult<Operation>("Operation added", operation, EpasResultCode.NoError);
    }

    public async Task<bool> UpdateOperationAsync(Order order)
    {
        
        var fOperation = await GetOperationAsync(order.Operationid) ?? (await AddOperationAsync(order)).Result;
        
        var originId = await dbContext.Origins.FirstOrDefaultAsync(x => x.Id == order.WasOrigin.Tid) ?? await originService.AddOriginAsync(order.WasOrigin);

        var program = await dbContext.Programs.FirstOrDefaultAsync(x => x.Name == order.Program) ?? await programService.AddProgramAsync(order);
        
        var caller = await dbContext.Callers.FirstOrDefaultAsync(x => x.Name == order.Caller) ?? (await callerService.AddCallerAsync(new Caller(){Name = order.Caller})).Result;
        
        var operationName = await dbContext.OperationNames.FirstOrDefaultAsync(x => x.Name == order.Operationname) ?? (await AddOperationNameAsync(order.Operationname)).Result;

        List<Firebrigade> firebrigades = new();
        
        foreach (var destination in order.Destinationlist.Destination)
        {
            var fireBrigades = await firebrigadeService.GetFirebrigadeAsync(destination.Text);
            if (fireBrigades.Result != new Firebrigade())
            {
                firebrigades.Add(fireBrigades.Result);
            }
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
        fOperation.Firebrigades = firebrigades;
        
        dbContext.Operations.Update(fOperation);
        var res = await dbContext.SaveChangesAsync();
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

    public async Task<bool> AddOperationResponseAsync(OperationResponse operationResponse)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateOperationResponseAsync(OperationResponse operationResponse)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteOperationResponseAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AddOperationNameAsync(OperationName operationName)
    {
        var res = await dbContext.OperationNames.FirstOrDefaultAsync(x => x.Name == operationName.Name);
        if (res != null)
        {
            return false;
        }
        await dbContext.OperationNames.AddAsync(operationName);
        var res2 = await dbContext.SaveChangesAsync();
        return res2 > 0;
    }

    public async Task<EpasResult<OperationName>> AddOperationNameAsync(string operationName)
    {
        var res = await dbContext.OperationNames.FirstOrDefaultAsync(x => x.Name == operationName);
        if (res != null)
        {
            return new EpasResult<OperationName>("Operation name already exists", res, EpasResultCode.AlreadyExists);
        }
        await dbContext.OperationNames.AddAsync(new OperationName(){Name = operationName});
        var res2 = await dbContext.SaveChangesAsync();
        if (res2 > 0)
        {
            return new EpasResult<OperationName>("Operation name added", new OperationName(){Name = operationName}, EpasResultCode.NoError);
        }
        else
        {
            return new EpasResult<OperationName>("Operation name couldn't be added", new OperationName(), EpasResultCode.CouldntAddOperation);
        }
    }

    public async Task<bool> FinishAllOperationsAsync(string operationApiKey)
    {
        var res = await dbContext.Applications.Include(x => x.Firebrigade).ThenInclude(x => x.Operations).FirstOrDefaultAsync(x => x.ApiKey == operationApiKey);
        var openOperations = res.Firebrigade.Operations.Where(x => x.Completed == null).ToList();
        
        foreach (var operation in openOperations)
        {
            operation.Completed = DateTime.Now;
            dbContext.Operations.Update(operation);
        }
        
        var res2 = await dbContext.SaveChangesAsync();
        return res2 > 0;
    }
}