using Volo.Abp.Reflection;

namespace TMT.MS.Permissions;

public class MSPermissions
{
    public const string GroupName = "MS";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MSPermissions));
    }
}
