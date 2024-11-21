using Volo.Abp.Modularity;

namespace JLaraSystemLeng;

/* Inherit from this class for your domain layer tests. */
public abstract class JLaraSystemLengDomainTestBase<TStartupModule> : JLaraSystemLengTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
