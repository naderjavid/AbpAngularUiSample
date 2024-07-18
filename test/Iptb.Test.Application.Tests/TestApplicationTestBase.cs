using Volo.Abp.Modularity;

namespace Iptb.Test;

public abstract class TestApplicationTestBase<TStartupModule> : TestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
