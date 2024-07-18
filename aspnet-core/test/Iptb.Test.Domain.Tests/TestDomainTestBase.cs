using Volo.Abp.Modularity;

namespace Iptb.Test;

/* Inherit from this class for your domain layer tests. */
public abstract class TestDomainTestBase<TStartupModule> : TestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
