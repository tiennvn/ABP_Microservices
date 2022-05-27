using TMT.MS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TMT.MS.Permissions;

public class MSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MSPermissions.GroupName, L("Permission:MS"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MSResource>(name);
    }
}
