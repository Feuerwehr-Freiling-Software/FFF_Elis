using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface ICallerService
{
    public Task<Caller?> GetCallerAsync(int id);
    public Task<Caller?> GetCallerAsync(string name);
    public Task<List<Caller>> GetCallersAsync();
    public Task<EpasResult<Caller>> AddOrUpdateCallerAsync(string name);
    public Task<EpasResult<Caller>> AddCallerAsync(Caller caller);
    public Task<EpasResult<Caller>?> UpdateCallerAsync(Caller caller);
    public Task<bool> DeleteCallerAsync(int id);
}