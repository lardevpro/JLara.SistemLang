using Microsoft.Extensions.Localization;
using JLaraSystemLeng.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace JLaraSystemLeng;

[Dependency(ReplaceServices = true)]
public class JLaraSystemLengBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<JLaraSystemLengResource> _localizer;

    public JLaraSystemLengBrandingProvider(IStringLocalizer<JLaraSystemLengResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
