using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SeerBI.Web.Areas.Identity.Data;
using SeerBI.Web.Models;

namespace SeerBI.Web.Data;

public class SeerBIWebContext : IdentityDbContext<SeerBIWebUser>
{

    public SeerBIWebContext(DbContextOptions<SeerBIWebContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new SeerBIWebUserEntityConfiguration());

    }
}
public class SeerBIWebUserEntityConfiguration : IEntityTypeConfiguration<SeerBIWebUser>
{
    void IEntityTypeConfiguration<SeerBIWebUser>.Configure(EntityTypeBuilder<SeerBIWebUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
        builder.Property(u => u.category).HasMaxLength(255);
        builder.Property(u => u.profession).HasMaxLength(255);

    }
}
