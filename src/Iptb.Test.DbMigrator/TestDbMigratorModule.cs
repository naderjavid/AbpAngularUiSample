using Iptb.Test.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Iptb.Test.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestEntityFrameworkCoreModule),
    typeof(TestApplicationContractsModule)
    )]
public class TestDbMigratorModule : AbpModule
{
}
