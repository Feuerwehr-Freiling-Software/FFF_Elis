using System.Xml.Resolvers;
using EPAS.Core.BusinessObjects;
using EPAS.Core.Models;

namespace EPAS.Core.Interfaces;

public interface IProgramService
{
    public Task<Program?> GetProgramAsync(int id);
    public Task<Program?> GetProgramAsync(Order order);
    public Task<List<Program>> GetProgramsAsync();
    public Task<EpasResult<Program>> AddOrUpdateProgramAsync(Order order);
    public Task<Program> AddProgramAsync(Program program);
    public Task<Program> AddProgramAsync(Order program);
    public Task<Program?> UpdateProgramAsync(Order program);
    public Task<Program?> UpdateProgramAsync(Program program);
    public Task<bool> DeleteProgramAsync(int id);
}