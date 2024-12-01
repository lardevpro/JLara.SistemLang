using JLaraSystemLeng.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace JLaraSystemLeng.Permissions; //2� asignacion de los permisos

public class JLaraSystemLengPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var permisosUusario = context.AddGroup(JLaraSystemLengPermissions.GroupName);//variable que guarda los permisos

        //Define your own permissions here. Example:
        //myGroup.AddPermission(JLaraSystemLengPermissions.MyPermission1, L("Permission:MyPermission1"));//ejemplo para a�adi un permiso
        permisosUusario.AddPermission(JLaraSystemLengPermissions.Tutoria, L("Permission:Tutoria")); //a�adir el permiso tutoria
        permisosUusario.AddPermission(JLaraSystemLengPermissions.Progreso, L("Permission:Progreso"));//a�adir el permiso Progreso

        var exercisePermission = permisosUusario.AddPermission(JLaraSystemLengPermissions.Exercise.Default, L("Permission:Exercise"));
        exercisePermission.AddChild(JLaraSystemLengPermissions.Exercise.Create, L("Permission:Create"));
        exercisePermission.AddChild(JLaraSystemLengPermissions.Exercise.Update, L("Permission:Update"));
        exercisePermission.AddChild(JLaraSystemLengPermissions.Exercise.Delete, L("Permission:Delete"));

        var progresPermission = permisosUusario.AddPermission(JLaraSystemLengPermissions.Progres.Default, L("Permission:Progres"));
        progresPermission.AddChild(JLaraSystemLengPermissions.Progres.Create, L("Permission:Create"));
        progresPermission.AddChild(JLaraSystemLengPermissions.Progres.Update, L("Permission:Update"));
        progresPermission.AddChild(JLaraSystemLengPermissions.Progres.Delete, L("Permission:Delete"));

        var sugesstionPermission = permisosUusario.AddPermission(JLaraSystemLengPermissions.Sugesstion.Default, L("Permission:Sugesstion"));
        sugesstionPermission.AddChild(JLaraSystemLengPermissions.Sugesstion.Create, L("Permission:Create"));
        sugesstionPermission.AddChild(JLaraSystemLengPermissions.Sugesstion.Update, L("Permission:Update"));
        sugesstionPermission.AddChild(JLaraSystemLengPermissions.Sugesstion.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<JLaraSystemLengResource>(name);
    }
}
