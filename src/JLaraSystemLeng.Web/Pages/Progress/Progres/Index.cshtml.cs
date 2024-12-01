using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace JLaraSystemLeng.Web.Pages.Progress.Progres;

public class IndexModel : JLaraSystemLengPageModel
{
    public ProgresFilterInput ProgresFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class ProgresFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProgresUserId")]
    public Guid? UserId { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProgresPracticeDate")]
    public DateTime? PracticeDate { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProgresPronunciationAccuracy")]
    public decimal? PronunciationAccuracy { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProgresRecommendation")]
    public string? Recommendation { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProgresDifficultyLevel")]
    public string? DifficultyLevel { get; set; }
}
