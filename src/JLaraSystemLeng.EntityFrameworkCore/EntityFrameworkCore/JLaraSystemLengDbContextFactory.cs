using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace JLaraSystemLeng.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class JLaraSystemLengDbContextFactory : IDesignTimeDbContextFactory<JLaraSystemLengDbContext>
{
    public JLaraSystemLengDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        JLaraSystemLengEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<JLaraSystemLengDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);
        
        return new JLaraSystemLengDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../JLaraSystemLeng.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
