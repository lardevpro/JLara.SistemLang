using System.Threading.Tasks;

namespace JLaraSystemLeng.Data;

public interface IJLaraSystemLengDbSchemaMigrator
{
    Task MigrateAsync();
}
