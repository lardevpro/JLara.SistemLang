using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace JLaraSystemLeng.Web.Pages.Exercise.Exercise;

public class IndexModel : JLaraSystemLengPageModel
{
    public ExerciseFilterInput ExerciseFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class ExerciseFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ExerciseUserId")]
    public Guid? UserId { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ExercisePhrase")]
    public int? Phrase { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ExerciseDifficultyLevel")]
    public string? DifficultyLevel { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ExerciseFocusArea")]
    public string? FocusArea { get; set; }
}
