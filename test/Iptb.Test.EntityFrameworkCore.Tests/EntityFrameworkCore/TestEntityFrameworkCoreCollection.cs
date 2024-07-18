using Xunit;

namespace Iptb.Test.EntityFrameworkCore;

[CollectionDefinition(TestTestConsts.CollectionDefinitionName)]
public class TestEntityFrameworkCoreCollection : ICollectionFixture<TestEntityFrameworkCoreFixture>
{

}
