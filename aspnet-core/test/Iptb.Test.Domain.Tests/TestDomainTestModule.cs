using Volo.Abp.Modularity;

namespace Iptb.Test;

[DependsOn(
    typeof(TestDomainModule),
    typeof(TestTestBaseModule)
)]
public class TestDomainTestModule : AbpModule
{

}
