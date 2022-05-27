using TMT.MS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TMT.MS;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(MSEntityFrameworkCoreTestModule)
    )]
public class MSDomainTestModule : AbpModule
{

}
