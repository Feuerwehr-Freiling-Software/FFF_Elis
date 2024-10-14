using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;
using EPAS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EPAS.BusinessLogic.Services;

public class APIKeyService(ApplicationDbContext db, ILogger<APIKeyService> logger) : IAPIKeyService
{
    public ILogger<APIKeyService> Logger { get; } = logger;
    private readonly ApplicationDbContext _db = db;

    public async Task<bool> ValidateKey(string fireBrigadeName, string key)
    {
        var application = db.Applications.Include(x => x.Firebrigade).FirstOrDefault(x => x.ApiKey == key && x.Firebrigade.Name == fireBrigadeName);
        if (application == null)
        {
            Logger.LogWarning("Invalid API key for {FireBrigadeName}", fireBrigadeName);
            return false;
        }
        
        Logger.LogInformation("Valid API key for {FireBrigadeName}", fireBrigadeName);
        return true;
    }

    public async Task<EpasResult<List<Firebrigade>>> GetAllFireBrigades()
    {
        var res = db.Firebrigades.ToList();
        return new EpasResult<List<Firebrigade>>("Success", res, EpasResultCode.NoError);
    }
}