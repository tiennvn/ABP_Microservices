using Localization.Resources.AbpUi;
using TMT.MS.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace TMT.MS;

[DependsOn(
    typeof(MSApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class MSHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(MSHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MSResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
