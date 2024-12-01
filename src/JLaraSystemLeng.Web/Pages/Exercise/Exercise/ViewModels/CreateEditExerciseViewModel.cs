using System;
using System.ComponentModel.DataAnnotations;

namespace JLaraSystemLeng.Web.Pages.Exercise.Exercise.ViewModels;

public class CreateEditExerciseViewModel
{
    [Display(Name = "ExerciseUserId")]
    public Guid UserId { get; set; }

    [Display(Name = "ExercisePhrase")]
    public int? Phrase { get; set; }

    [Display(Name = "ExerciseDifficultyLevel")]
    public string? DifficultyLevel { get; set; }

    [Display(Name = "ExerciseFocusArea")]
    public string FocusArea { get; set; }
}
