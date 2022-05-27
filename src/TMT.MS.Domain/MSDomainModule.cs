using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace TMT.MS;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(MSDomainSharedModule)
)]
public class MSDomainModule : AbpModule
{

}
