using Iptb.Test.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Iptb.Test.Blazor.WebApp.Tiered.Client;

public abstract class TestComponentBase : AbpComponentBase
{
    protected TestComponentBase()
    {
        LocalizationResource = typeof(TestResource);
    }
}
