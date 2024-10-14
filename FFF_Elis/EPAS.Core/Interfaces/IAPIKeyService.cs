using EPAS.Core.BusinessObjects;

namespace EPAS.Core.Models;

public interface IAPIKeyService
{
    Task<bool> ValidateKey(string fireBrigadeName, string key);
    Task<EpasResult<List<Firebrigade>>> GetAllFireBrigades();
}