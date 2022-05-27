using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace TMT.MS.EntityFrameworkCore;

[ConnectionStringName(MSDbProperties.ConnectionStringName)]
public interface IMSDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
