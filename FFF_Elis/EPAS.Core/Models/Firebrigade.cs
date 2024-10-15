using System.Text.Json.Serialization;

namespace EPAS.Core.Models;

public class Firebrigade
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public float Lat { get; set; } = 0;
    public float Lng { get; set; } = 0;
    public List<ApplicationUser> Users { get; set; } = new();
    [JsonIgnore]
    public List<Operation> Operations { get; set; } = new();
    [JsonIgnore]
    public List<Application> Applications { get; set; } = new();
}