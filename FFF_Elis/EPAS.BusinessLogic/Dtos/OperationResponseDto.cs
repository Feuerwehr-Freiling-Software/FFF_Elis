using EPAS.Core.Enums;
using EPAS.Core.Models;

namespace EPAS.BusinessLogic.Dtos;

public class OperationResponseDto
{
    public string OperationId { get; set; }
    public string Username { get; set; }
    public OperationResponseEnum Response { get; set; }
    public List<Qualifications> Qualifications { get; set; } = new();
}