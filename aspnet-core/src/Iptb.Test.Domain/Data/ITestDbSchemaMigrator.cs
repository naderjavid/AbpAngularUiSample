using System.Threading.Tasks;

namespace Iptb.Test.Data;

public interface ITestDbSchemaMigrator
{
    Task MigrateAsync();
}
