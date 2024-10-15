using EPAS.Core.Models;

namespace EPAS.BusinessLogic.Dtos;

public class OperationDto
{
    public string OperationId { get; set; } = string.Empty;
    public string OriginName { get; set; } = string.Empty;
    public string ProgramName { get; set; } = string.Empty;
    public string CallerName { get; set; } = string.Empty;
    public string Injured { get; set; } = string.Empty;
    public string OperationName { get; set; } = string.Empty;
    public DateTime Recieved { get; set; }
    public DateTime? Completed { get; set; }
    public int Level { get; set; }
    public string Info { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public List<OperationResponseDto> OperationResponses { get; set; } = new();
    public List<Firebrigade> Firebrigades { get; set; } = new();
}