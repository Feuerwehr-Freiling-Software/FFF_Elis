using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface IOperationHub
{
    Task<EpasResult<bool>> RegisterClient(string firebrigadename, string apiKey);
    Task<EpasResult<bool>> NewOperation(string firebrigadename, WASMessage operation);
}