using System;
using System.Collections.Generic;
using System.Text;
using Iptb.Test.Localization;
using Volo.Abp.Application.Services;

namespace Iptb.Test;

/* Inherit your application services from this class.
 */
public abstract class TestAppService : ApplicationService
{
    protected TestAppService()
    {
        LocalizationResource = typeof(TestResource);
    }
}
