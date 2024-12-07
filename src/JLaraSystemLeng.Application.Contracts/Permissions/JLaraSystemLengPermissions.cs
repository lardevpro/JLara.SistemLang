namespace JLaraSystemLeng.Permissions;


public static class JLaraSystemLengPermissions //1� declaracion de los permisos y los grupos
{
    public const string GroupName = "GrupoUsusarios"; //grupo al que se les daran los permisos

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public const string Tutoria = GroupName + "Tutoria"; //crear persmiso tutor�a
    public const string Progreso = GroupName + "Progreso"; //crear permiso progreso

    public class Exercise
    {
        public const string Default = GroupName + ".Exercise";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class Progres
    {
        public const string Default = GroupName + ".Progres";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
