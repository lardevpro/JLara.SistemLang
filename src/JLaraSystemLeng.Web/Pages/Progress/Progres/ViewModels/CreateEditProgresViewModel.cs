using System;
using System.ComponentModel.DataAnnotations;

namespace JLaraSystemLeng.Web.Pages.Progress.Progres.ViewModels;

public class CreateEditProgresViewModel
{
    [Display(Name = "ProgresUserId")]
    public Guid UserId { get; set; }

    [Display(Name = "ProgresPracticeDate")]
    public DateTime? PracticeDate { get; set; }

    [Display(Name = "ProgresPronunciationAccuracy")]
    public decimal? PronunciationAccuracy { get; set; }

    [Display(Name = "ProgresRecommendation")]
    public string? Recommendation { get; set; }

    [Display(Name = "ProgresDifficultyLevel")]
    public string? DifficultyLevel { get; set; }
}
