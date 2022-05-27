using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace TMT.MS.MongoDB;

[ConnectionStringName(MSDbProperties.ConnectionStringName)]
public interface IMSMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
