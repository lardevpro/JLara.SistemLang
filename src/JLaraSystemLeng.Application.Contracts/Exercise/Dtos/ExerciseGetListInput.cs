using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace JLaraSystemLeng.Exercise.Dtos;

[Serializable]
public class ExerciseGetListInput : PagedAndSortedResultRequestDto
{
    public Guid? UserId { get; set; }

    public int? Phrase { get; set; }

    public string? DifficultyLevel { get; set; }

    public string? FocusArea { get; set; }
}