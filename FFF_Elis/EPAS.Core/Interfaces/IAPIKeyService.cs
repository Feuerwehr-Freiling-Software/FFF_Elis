namespace EPAS.Core.Models;

public interface IAPIKeyService
{
    Task<bool> ValidateKey(string fireBrigadeName, string key);
}