using Volo.Abp.Modularity;

namespace JLaraSystemLeng;

[DependsOn(
    typeof(JLaraSystemLengDomainModule),
    typeof(JLaraSystemLengTestBaseModule)
)]
public class JLaraSystemLengDomainTestModule : AbpModule
{

}
