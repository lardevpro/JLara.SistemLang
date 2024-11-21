using JLaraSystemLeng.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace JLaraSystemLeng.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(JLaraSystemLengEntityFrameworkCoreModule),
    typeof(JLaraSystemLengApplicationContractsModule)
)]
public class JLaraSystemLengDbMigratorModule : AbpModule
{
}
