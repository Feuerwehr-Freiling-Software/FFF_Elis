using EPAS.Core.Enums;

namespace EPAS.Core.Models;

public class OperationResponse
{
    public int Id { get; set; }
    
    public string OperationId { get; set; }
    public Operation Operation { get; set; }
    
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }

    public OperationResponseEnum Response { get; set; }
}