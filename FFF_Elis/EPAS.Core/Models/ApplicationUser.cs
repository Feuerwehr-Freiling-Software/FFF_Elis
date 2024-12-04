using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EPAS.Core.Models;

public class ApplicationUser : IdentityUser
{
    public List<Qualifications> Qualifications { get; set; } = new();
    public List<Firebrigade> Firebrigades { get; set; } = new();
    
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
}