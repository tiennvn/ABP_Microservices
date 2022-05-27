using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace TMT.MS.Blazor.WebAssembly;

[DependsOn(
    typeof(MSBlazorModule),
    typeof(MSHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class MSBlazorWebAssemblyModule : AbpModule
{

}
