namespace JLaraSystemLeng.Permissions;


public static class JLaraSystemLengPermissions //1º declaracion de los permisos y los grupos
{
    public const string GroupName = "GrupoUsusarios"; //grupo al que se les daran los permisos

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public const string Tutoria = GroupName + "Tutoria"; //crear persmiso tutoría
    public const string Progreso = GroupName + "Progreso"; //crear permiso progreso

}
