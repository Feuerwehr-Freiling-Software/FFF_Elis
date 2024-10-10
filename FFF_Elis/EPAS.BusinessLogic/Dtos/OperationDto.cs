namespace EPAS.BusinessLogic.Dtos;

public class OperationDto
{
    public string OperationId { get; set; }
    public string OriginName { get; set; }
    public string ProgramName { get; set; }
    public string CallerName { get; set; }
    public string Injured { get; set; }
    public string OperationName { get; set; }
    public DateTime Recieved { get; set; }
    public DateTime? Completed { get; set; }
    public int Level { get; set; }
    public string Info { get; set; }
    public string Adress { get; set; }
    public List<OperationResponseDto> OperationResponses { get; set; } = new();
}