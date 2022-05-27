using TMT.MS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TMT.MS.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MSPageModel : AbpPageModel
{
    protected MSPageModel()
    {
        LocalizationResourceType = typeof(MSResource);
        ObjectMapperContext = typeof(MSWebModule);
    }
}
