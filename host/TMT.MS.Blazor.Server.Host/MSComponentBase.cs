using TMT.MS.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TMT.MS.Blazor.Server.Host;

public abstract class MSComponentBase : AbpComponentBase
{
    protected MSComponentBase()
    {
        LocalizationResource = typeof(MSResource);
    }
}
