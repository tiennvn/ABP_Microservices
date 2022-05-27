using TMT.MS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TMT.MS.Pages;

public abstract class MSPageModel : AbpPageModel
{
    protected MSPageModel()
    {
        LocalizationResourceType = typeof(MSResource);
    }
}
