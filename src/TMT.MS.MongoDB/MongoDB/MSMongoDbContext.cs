using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace TMT.MS.MongoDB;

[ConnectionStringName(MSDbProperties.ConnectionStringName)]
public class MSMongoDbContext : AbpMongoDbContext, IMSMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureMS();
    }
}
