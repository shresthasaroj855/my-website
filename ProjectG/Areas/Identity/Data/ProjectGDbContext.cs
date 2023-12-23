using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectG.Areas.Identity.Data;

namespace ProjectG.Data;

public class ProjectGDbContext : IdentityDbContext<ApplicationUser>
{
    public ProjectGDbContext(DbContextOptions<ProjectGDbContext> options)
        : base(options)
    {
    }

    public DbSet<Membership> Memberships { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}