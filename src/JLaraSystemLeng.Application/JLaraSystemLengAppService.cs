using JLaraSystemLeng.Localization;
using Volo.Abp.Application.Services;

namespace JLaraSystemLeng;

/* Inherit your application services from this class.
 */
public abstract class JLaraSystemLengAppService : ApplicationService
{
    protected JLaraSystemLengAppService()
    {
        LocalizationResource = typeof(JLaraSystemLengResource);
    }
}
