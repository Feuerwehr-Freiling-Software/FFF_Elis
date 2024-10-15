using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface IOriginService
{
    public Task<Origin?> GetOriginAsync(int id);
    public Task<List<Origin>> GetOriginsAsync();
    public Task<EpasResult<Origin>> AddOrUpdateOriginAsync(WASOrigin message);
    public Task<Origin> AddOriginAsync(Origin origin);
    public Task<Origin> AddOriginAsync(WASOrigin origin);
    public Task<Origin?> UpdateOriginAsync(WASOrigin origin);
    public Task<bool> DeleteOriginAsync(int id);
}