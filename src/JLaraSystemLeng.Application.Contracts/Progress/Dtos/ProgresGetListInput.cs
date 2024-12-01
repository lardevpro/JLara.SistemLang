using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace JLaraSystemLeng.Progress.Dtos;

[Serializable]
public class ProgresGetListInput : PagedAndSortedResultRequestDto
{
    public Guid? UserId { get; set; }

    public DateTime? PracticeDate { get; set; }

    public decimal? PronunciationAccuracy { get; set; }

    public string? Recommendation { get; set; }

    public string? DifficultyLevel { get; set; }
}