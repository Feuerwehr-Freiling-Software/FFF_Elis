using EPAS.BusinessLogic.Dtos;
using EPAS.Core.Models;

namespace EPAS.BusinessLogic.Helper;

public static class ExtensionMethods
{
    public static List<OperationDto> ToOperationDto(this List<Operation> operations)
    {
        return operations.Select(x => new OperationDto()
        {
            CallerName = x.Caller.Name,
            Injured = x.Caller.Geschaedigter,
            Completed = x.Completed,
            Recieved = x.Recieved,
            Firebrigades = x.Firebrigades,
            OperationId = x.Id,
            OperationName = x.OperationName.Name,
            OriginName = x.Origin.Name,
            ProgramName = x.Program.Name,
            Adress = x.Adress,
            Info = x.Info,
            OperationResponses = x.OperationResponses.Select(x => new OperationResponseDto()
            {
                OperationId = x.OperationId,
                Username = x.User?.UserName ?? string.Empty,
                Response = x.Response,
                Qualifications = x.User?.Qualifications ?? []
            }).ToList(),
        }).ToList();
    }
}