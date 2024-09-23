namespace EPAS.Core.Models;

public class Operation
{
    public string Id { get; set; }
    public int OriginId { get; set; }
    public Origin Origin { get; set; }
    public int ProgramId { get; set; }
    public Program Program { get; set; }
    public int CallerId { get; set; }
    public Caller Caller { get; set; }
    public int OperationNameId { get; set; }
    public OperationName OperationName { get; set; }

    public DateTime Recieved { get; set; }
    public DateTime? Completed { get; set; }
    public int Level { get; set; }
    public string Info { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public List<OperationResponse> OperationResponses { get; set; } = new();
}