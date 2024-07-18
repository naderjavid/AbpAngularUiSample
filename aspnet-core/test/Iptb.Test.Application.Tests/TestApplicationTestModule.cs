using Volo.Abp.Modularity;

namespace Iptb.Test;

[DependsOn(
    typeof(TestApplicationModule),
    typeof(TestDomainTestModule)
)]
public class TestApplicationTestModule : AbpModule
{

}
