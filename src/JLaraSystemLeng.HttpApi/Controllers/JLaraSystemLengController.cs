using JLaraSystemLeng.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace JLaraSystemLeng.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class JLaraSystemLengController : AbpControllerBase
{
    protected JLaraSystemLengController()
    {
        LocalizationResource = typeof(JLaraSystemLengResource);
    }
}
