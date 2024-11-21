using JLaraSystemLeng.Samples;
using Xunit;

namespace JLaraSystemLeng.EntityFrameworkCore.Domains;

[Collection(JLaraSystemLengTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<JLaraSystemLengEntityFrameworkCoreTestModule>
{

}
