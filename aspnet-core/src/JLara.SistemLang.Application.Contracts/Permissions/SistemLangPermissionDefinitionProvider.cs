using JLara.SistemLang.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace JLara.SistemLang.Permissions;

public class SistemLangPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SistemLangPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SistemLangPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SistemLangResource>(name);
    }
}
