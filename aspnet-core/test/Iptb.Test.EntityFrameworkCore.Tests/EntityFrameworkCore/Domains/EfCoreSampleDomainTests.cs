using Iptb.Test.Samples;
using Xunit;

namespace Iptb.Test.EntityFrameworkCore.Domains;

[Collection(TestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TestEntityFrameworkCoreTestModule>
{

}
