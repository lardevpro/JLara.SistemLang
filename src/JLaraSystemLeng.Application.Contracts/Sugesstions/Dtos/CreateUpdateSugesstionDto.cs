using System;

namespace JLaraSystemLeng.Sugesstions.Dtos;

[Serializable]
public class CreateUpdateSugesstionDto
{
    public Guid UserId { get; set; }

    public string? SugesstionText { get; set; }

    public DateTime? SugesstionCreationDate { get; set; }
}