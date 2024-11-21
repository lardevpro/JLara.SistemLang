using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JLaraSystemLeng.Data;
using Volo.Abp.DependencyInjection;

namespace JLaraSystemLeng.EntityFrameworkCore;

public class EntityFrameworkCoreJLaraSystemLengDbSchemaMigrator
    : IJLaraSystemLengDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreJLaraSystemLengDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the JLaraSystemLengDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<JLaraSystemLengDbContext>()
            .Database
            .MigrateAsync();
    }
}
