using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;

namespace EPAS.BusinessLogic.Services;

public class FirebrigadeService(ApplicationDbContext db) : IFirebrigadeService
{
    private readonly ApplicationDbContext _db = db;

    public async Task<EpasResult<Firebrigade>> GetFirebrigadeAsync(int id)
    {
        var firebrigade = await db.Firebrigades.FirstOrDefaultAsync(x => x.Id == id);
        if (firebrigade == null)
        {
            return new EpasResult<Firebrigade>("Firebrigade not found", new Firebrigade(), EpasResultCode.CouldntFindFirebrigade);
        }
        else
        {
            return new EpasResult<Firebrigade>("Firebrigade found", firebrigade, EpasResultCode.NoError);
        }
    }

    public async Task<EpasResult<Firebrigade>> GetFirebrigadeAsync(string name)
    {
        var firebrigade = await db.Firebrigades.FirstOrDefaultAsync(x => x.Name == name);
        if (firebrigade == null)
        {
            return new EpasResult<Firebrigade>("Firebrigade not found", new Firebrigade(), EpasResultCode.CouldntFindFirebrigade);
        }
        else
        {
            return new EpasResult<Firebrigade>("Firebrigade found", firebrigade, EpasResultCode.NoError);
        }
    }
}