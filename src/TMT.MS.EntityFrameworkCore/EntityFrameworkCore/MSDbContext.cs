using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace TMT.MS.EntityFrameworkCore;

[ConnectionStringName(MSDbProperties.ConnectionStringName)]
public class MSDbContext : AbpDbContext<MSDbContext>, IMSDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public MSDbContext(DbContextOptions<MSDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureMS();
    }
}
