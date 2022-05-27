using TMT.MS.Localization;
using Volo.Abp.Application.Services;

namespace TMT.MS;

public abstract class MSAppService : ApplicationService
{
    protected MSAppService()
    {
        LocalizationResource = typeof(MSResource);
        ObjectMapperContext = typeof(MSApplicationModule);
    }
}
