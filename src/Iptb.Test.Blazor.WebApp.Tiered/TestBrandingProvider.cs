using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Iptb.Test.Blazor.WebApp.Tiered;

[Dependency(ReplaceServices = true)]
public class TestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Test";
}
