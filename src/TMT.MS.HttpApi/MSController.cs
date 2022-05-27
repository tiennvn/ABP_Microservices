using TMT.MS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TMT.MS;

public abstract class MSController : AbpControllerBase
{
    protected MSController()
    {
        LocalizationResource = typeof(MSResource);
    }
}
