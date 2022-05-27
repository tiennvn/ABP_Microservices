using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TMT.MS.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class MSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MS";
}
