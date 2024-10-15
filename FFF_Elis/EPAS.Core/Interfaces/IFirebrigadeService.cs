using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface IFirebrigadeService
{
    Task<EpasResult<Firebrigade>> GetFirebrigadeAsync(int id);
    Task<EpasResult<Firebrigade>> GetFirebrigadeAsync(string name);
}