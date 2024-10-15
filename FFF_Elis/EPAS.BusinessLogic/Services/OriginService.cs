using EPAS.Core.BusinessObjects;
using EPAS.Core.Interfaces;
using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;

namespace EPAS.BusinessLogic.Services;

public class OriginService(ApplicationDbContext db) : IOriginService
{

    public async Task<Origin?> GetOriginAsync(int id)
    {
        var res = await db.Origins.FindAsync(id);
        return res;
    }

    public async Task<List<Origin>> GetOriginsAsync()
    {
        var res = await db.Origins.ToListAsync();
        return res;
    }

    public async Task<EpasResult<Origin>> AddOrUpdateOriginAsync(WASOrigin origin)
    {
        var fOrigin = await GetOriginAsync(origin.Tid);
        if (fOrigin != null)
        {
            fOrigin.Name = origin.Text;
            await UpdateOriginAsync(fOrigin);
            return new EpasResult<Origin>("Origin updated", fOrigin, EpasResultCode.NoError);
        }
        else
        {
            var newOrigin = new Origin
            {
                Id = origin.Tid,
                Name = origin.Text
            };
            await AddOriginAsync(newOrigin);
            return new EpasResult<Origin>("Origin added", newOrigin, EpasResultCode.NoError);
        }
    }
    public async Task<Origin> AddOriginAsync(Origin origin)
    {
        var retOrigin = await db.Origins.AddAsync(origin);
        var res = await db.SaveChangesAsync();
        return retOrigin.Entity;
    }
    
    public async Task<Origin> AddOriginAsync(WASOrigin origin)
    {
        var newOrigin = new Origin
        {
            Id = origin.Tid,
            Name = origin.Text
        };
        var retOrigin = await db.Origins.AddAsync(newOrigin);
        var res = await db.SaveChangesAsync();
        return retOrigin.Entity;
    }
    
    public async Task<bool> UpdateOriginAsync(Origin origin)
    {
        db.Origins.Update(origin);
        var res = await db.SaveChangesAsync();
        return res > 0;
    }
    
    public async Task<Origin?> UpdateOriginAsync(WASOrigin origin)
    {
        var fOrigin = await db.Origins.FindAsync(origin.Tid);
        if (fOrigin == null) return null;
        
        fOrigin.Name = origin.Text;
        var retOrigin = db.Origins.Update(fOrigin);
        var res = await db.SaveChangesAsync();
        return retOrigin.Entity;
    }

    public async Task<bool> DeleteOriginAsync(int id)
    {
        var origin = await GetOriginAsync(id);
        if (origin == null) return false;
        
        db.Origins.Remove(origin);
        var res = await db.SaveChangesAsync();
        return res > 0;
    }
}