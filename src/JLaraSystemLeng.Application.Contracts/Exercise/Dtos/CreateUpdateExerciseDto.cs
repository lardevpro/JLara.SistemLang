using System;

namespace JLaraSystemLeng.Exercise.Dtos;

[Serializable]
public class CreateUpdateExerciseDto
{
    public Guid UserId { get; set; }

    public int? Phrase { get; set; }

    public string? DifficultyLevel { get; set; }

    public string FocusArea { get; set; }
}