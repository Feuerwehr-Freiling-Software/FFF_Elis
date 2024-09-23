using System.ComponentModel.DataAnnotations;

namespace EPAS.Core.Models;

public class Application
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [Required]
    public string ApiKey { get; set; } = string.Empty;

    public int FirebrigadeId { get; set; }
    public Firebrigade Firebrigade { get; set; } = null!;
}