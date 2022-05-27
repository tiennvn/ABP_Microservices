using Volo.Abp.Modularity;

namespace TMT.MS;

[DependsOn(
    typeof(MSApplicationModule),
    typeof(MSDomainTestModule)
    )]
public class MSApplicationTestModule : AbpModule
{

}
