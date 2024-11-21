using JLaraSystemLeng.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace JLaraSystemLeng.Permissions; //2º asignacion de los permisos

public class JLaraSystemLengPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var permisosUusario = context.AddGroup(JLaraSystemLengPermissions.GroupName);//variable que guarda los permisos

        //Define your own permissions here. Example:
        //myGroup.AddPermission(JLaraSystemLengPermissions.MyPermission1, L("Permission:MyPermission1"));//ejemplo para añadi un permiso
        permisosUusario.AddPermission(JLaraSystemLengPermissions.Tutoria, L("Permission:Tutoria")); //añadir el permiso tutoria
        permisosUusario.AddPermission(JLaraSystemLengPermissions.Progreso, L("Permission:Progreso");//añadir el permiso Progreso
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<JLaraSystemLengResource>(name);
    }
}
