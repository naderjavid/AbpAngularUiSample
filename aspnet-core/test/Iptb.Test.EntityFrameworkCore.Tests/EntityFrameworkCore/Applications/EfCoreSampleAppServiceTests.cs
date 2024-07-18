using Iptb.Test.Samples;
using Xunit;

namespace Iptb.Test.EntityFrameworkCore.Applications;

[Collection(TestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TestEntityFrameworkCoreTestModule>
{

}
