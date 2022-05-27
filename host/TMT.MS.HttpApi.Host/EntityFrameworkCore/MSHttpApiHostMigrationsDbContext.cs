using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace TMT.MS.EntityFrameworkCore;

public class MSHttpApiHostMigrationsDbContext : AbpDbContext<MSHttpApiHostMigrationsDbContext>
{
    public MSHttpApiHostMigrationsDbContext(DbContextOptions<MSHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureMS();
    }
}
