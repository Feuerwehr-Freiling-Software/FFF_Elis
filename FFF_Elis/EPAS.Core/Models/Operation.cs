namespace EPAS.Core.Models;

public class Operation
{
    public string Id { get; set; }
    public int OriginId { get; set; }
    public Origin Origin { get; set; } = new();
    public int ProgramId { get; set; }
    public Program Program { get; set; } = new();
    public int CallerId { get; set; }
    public Caller Caller { get; set; } = new();
    public int OperationNameId { get; set; }
    public OperationName OperationName { get; set; } = new();

    public DateTime Recieved { get; set; }
    public DateTime WatchOut { get; set; }
    public DateTime? Completed { get; set; }
    public int Level { get; set; }
    public string Info { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public List<OperationResponse> OperationResponses { get; set; } = new();
    public List<Firebrigade> Firebrigades { get; set; } = new();
}