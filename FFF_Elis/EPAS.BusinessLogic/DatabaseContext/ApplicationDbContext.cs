using EPAS.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EPAS.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Firebrigade> Firebrigades { get; set; }
    public DbSet<Caller> Callers { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<OperationName> OperationNames { get; set; }
    public DbSet<OperationResponse> OperationResponses { get; set; }
    public DbSet<Origin> Origins { get; set; }
    public DbSet<Program> Programs { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Qualifications> Qualifications { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("Claims");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        
        base.OnModelCreating(builder);
    }
}