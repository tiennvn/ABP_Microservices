using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TMT.MS;

[Dependency(ReplaceServices = true)]
public class MSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MS";
}
