using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace JLaraSystemLeng.Exercise.Dtos;

[Serializable]
public class ExerciseGetListInput : PagedAndSortedResultRequestDto
{
    [DisplayName("ExerciseUserId")]
    public Guid? UserId { get; set; }

    [DisplayName("ExercisePhrase")]
    public int? Phrase { get; set; }

    [DisplayName("ExerciseDifficultyLevel")]
    public string? DifficultyLevel { get; set; }

    [DisplayName("ExerciseFocusArea")]
    public string? FocusArea { get; set; }
}