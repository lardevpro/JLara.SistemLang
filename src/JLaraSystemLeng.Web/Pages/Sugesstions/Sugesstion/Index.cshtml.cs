using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace JLaraSystemLeng.Web.Pages.Sugesstions.Sugesstion;

public class IndexModel : JLaraSystemLengPageModel
{
    public SugesstionFilterInput SugesstionFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class SugesstionFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SugesstionUserId")]
    public Guid? UserId { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SugesstionSugesstionText")]
    public string? SugesstionText { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "SugesstionSugesstionCreationDate")]
    public DateTime? SugesstionCreationDate { get; set; }
}
