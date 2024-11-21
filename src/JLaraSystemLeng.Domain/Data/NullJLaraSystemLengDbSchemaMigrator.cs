using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace JLaraSystemLeng.Data;

/* This is used if database provider does't define
 * IJLaraSystemLengDbSchemaMigrator implementation.
 */
public class NullJLaraSystemLengDbSchemaMigrator : IJLaraSystemLengDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
