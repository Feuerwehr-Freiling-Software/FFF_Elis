using Microsoft.AspNetCore.Identity;

namespace EPAS.Core.Models;

public class ApplicationUser : IdentityUser
{
    public List<Qualifications> Qualifications { get; set; }
}