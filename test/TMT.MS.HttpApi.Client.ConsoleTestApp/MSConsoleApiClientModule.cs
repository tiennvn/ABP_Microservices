using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace TMT.MS;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MSHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class MSConsoleApiClientModule : AbpModule
{

}
