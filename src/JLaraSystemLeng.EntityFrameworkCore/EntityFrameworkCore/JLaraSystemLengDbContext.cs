using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using System.Diagnostics;
using JLaraSystemLeng.Progress;
using JLaraSystemLeng.Sugesstions;
using JLaraSystemLeng.Exercise;

namespace JLaraSystemLeng.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class JLaraSystemLengDbContext :
    AbpDbContext<JLaraSystemLengDbContext>,
    ITenantManagementDbContext,
    IIdentityDbContext
{

    /* Add DbSet properties for your Aggregate Roots / Entities here. */


    #region Entities from the modules

    /* Notice: We only implemented IIdentityProDbContext 
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityProDbContext .
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    // Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    public DbSet<Progres> Progress { get; set; }//2º añadir modelo
    public DbSet<Sugesstion> Sugesstions { get; set; }
    public DbSet<Exercises> Exercises { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public JLaraSystemLengDbContext(DbContextOptions<JLaraSystemLengDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureFeatureManagement();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureTenantManagement();
        builder.ConfigureBlobStoring();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(JLaraSystemLengConsts.DbTablePrefix + "YourEntities", JLaraSystemLengConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        builder.Entity<Progres>(b =>
        {
            b.ToTable(JLaraSystemLengConsts.DbTablePrefix + nameof(Progres), JLaraSystemLengConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserId);
            //...
        });
        builder.Entity<Sugesstion>(b =>
        {
            b.ToTable(JLaraSystemLengConsts.DbTablePrefix + nameof(Process), JLaraSystemLengConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.HasOne(p => p.User).WithMany().HasForeignKey(p => p.UserId);
            //...
        });
        builder.Entity<Exercises>(b =>
        {
            b.ToTable(JLaraSystemLengConsts.DbTablePrefix + "Exercises", JLaraSystemLengConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            //...
        });
    }
}
