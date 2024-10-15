using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;

namespace EPAS.BusinessLogic.Services;

public class CallerService(ApplicationDbContext db) : ICallerService
{
    public async Task<Caller?> GetCallerAsync(int id)
    {
        var res = await db.Callers.FindAsync(id);
        return res;
    }

    public async Task<Caller?> GetCallerAsync(string name)
    {
        var res = await db.Callers.FindAsync(name);
        return res;
    }

    public async Task<List<Caller>> GetCallersAsync()
    {
        var res = await db.Callers.ToListAsync();
        return res;
    }

    public async Task<EpasResult<Caller>> AddOrUpdateCallerAsync(string name)
    {
        var caller = await db.Callers.FirstOrDefaultAsync(x => x.Name == name);
        if (caller == null)
        {
            caller = new Caller { Name = name };
            db.Callers.Add(caller);
            await db.SaveChangesAsync();
            return new EpasResult<Caller>("Caller added", caller, EpasResultCode.NoError);
        }
        else
        {
            return new EpasResult<Caller>("Caller already exists", caller, EpasResultCode.AlreadyExists);
        }
    }

    public async Task<EpasResult<Caller>> AddCallerAsync(Caller caller)
    {
        var res = await db.Callers.FirstOrDefaultAsync(x => x.Name == caller.Name);
        if (res == null)
        {
            db.Callers.Add(caller);
            await db.SaveChangesAsync();
            return new EpasResult<Caller>("Caller added", caller, EpasResultCode.NoError);
        }
        else
        {
            return new EpasResult<Caller>("Caller already exists", caller, EpasResultCode.AlreadyExists);
        }
    }

    public async Task<EpasResult<Caller>?> UpdateCallerAsync(Caller caller)
    {
        var res = await db.Callers.FindAsync(caller.Id);
        if (res != null)
        {
            res.Name = caller.Name;
            var ret = db.Callers.Update(res);
            await db.SaveChangesAsync();
            return new EpasResult<Caller>("Caller updated", ret.Entity, EpasResultCode.NoError);
        }
        else
        {
            return new EpasResult<Caller>("Caller not found", new Caller(), EpasResultCode.CouldntFindFirebrigade);
        }
    }

    public async Task<bool> DeleteCallerAsync(int id)
    {
        var caller = await db.Callers.FindAsync(id);
        if (caller != null)
        {
            db.Callers.Remove(caller);
            await db.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }
}