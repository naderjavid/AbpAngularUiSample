using Iptb.Test.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Iptb.Test.Blazor.Client;

public abstract class TestComponentBase : AbpComponentBase
{
    protected TestComponentBase()
    {
        LocalizationResource = typeof(TestResource);
    }
}
