using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;

namespace EPAS.BusinessLogic.Services;

public class ProgramService(ApplicationDbContext db) : IProgramService
{
    public async Task<Program?> GetProgramAsync(int id)
    {
        var res = await db.Programs.FindAsync(id);
        return res;
    }

    public async Task<Program?> GetProgramAsync(Order order)
    {
        var res = await db.Programs.FirstOrDefaultAsync(x => x.Name == order.Program);
        return res;
    }

    public async Task<List<Program>> GetProgramsAsync()
    {
        var res = await db.Programs.ToListAsync();
        return res;
    }

    public async Task<EpasResult<Program>> AddOrUpdateProgramAsync(Order order)
    {
        var res = await GetProgramAsync(order) != null ? await UpdateProgramAsync(order) : await AddProgramAsync(order);

        if (res == null)
        {
            return new EpasResult<Program>("Program not added", new Program(), EpasResultCode.ProgramNotFound);
        }
        
        return new EpasResult<Program>("Program added", res, EpasResultCode.NoError);
    }

    public async Task<Program> AddProgramAsync(Program program)
    {
        var res = await db.Programs.AddAsync(program);
        await db.SaveChangesAsync();
        return res.Entity;
    }

    public async Task<Program> AddProgramAsync(Order program)
    {
        var res = await db.Programs.AddAsync(new Program { Name = program.Program });
        await db.SaveChangesAsync();
        return res.Entity;
    }

    public async Task<Program?> UpdateProgramAsync(Order program)
    {
        var res = await GetProgramAsync(program);
        if (res == null)
        {
            return null;
        }

        res.Name = program.Program;
        db.Programs.Update(res);
        await db.SaveChangesAsync();
        return res;
    }

    public async Task<Program?> UpdateProgramAsync(Program program)
    {
        var res = await GetProgramAsync(program.Id);
        if (res == null)
        {
            return null;
        }

        res.Name = program.Name;
        db.Programs.Update(res);
        await db.SaveChangesAsync();
        return res;
    }

    public async Task<bool> DeleteProgramAsync(int id)
    {
        var res = await GetProgramAsync(id);
        if (res == null)
        {
            return false;
        }

        db.Programs.Remove(res);
        await db.SaveChangesAsync();
        return true;
    }
}