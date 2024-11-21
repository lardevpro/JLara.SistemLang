using Volo.Abp.Modularity;

namespace JLaraSystemLeng;

[DependsOn(
    typeof(JLaraSystemLengApplicationModule),
    typeof(JLaraSystemLengDomainTestModule)
)]
public class JLaraSystemLengApplicationTestModule : AbpModule
{

}
