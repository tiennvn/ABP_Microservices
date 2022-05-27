using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace TMT.MS.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(MSBlazorModule)
    )]
public class MSBlazorServerModule : AbpModule
{

}
