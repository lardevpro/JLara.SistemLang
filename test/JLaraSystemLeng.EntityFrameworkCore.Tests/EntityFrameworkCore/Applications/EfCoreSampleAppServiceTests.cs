using JLaraSystemLeng.Samples;
using Xunit;

namespace JLaraSystemLeng.EntityFrameworkCore.Applications;

[Collection(JLaraSystemLengTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<JLaraSystemLengEntityFrameworkCoreTestModule>
{

}
