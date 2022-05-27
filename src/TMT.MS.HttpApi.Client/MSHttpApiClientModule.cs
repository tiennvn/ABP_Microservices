using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace TMT.MS;

[DependsOn(
    typeof(MSApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class MSHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(MSApplicationContractsModule).Assembly,
            MSRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MSHttpApiClientModule>();
        });

    }
}
