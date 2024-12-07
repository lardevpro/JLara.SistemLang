using System;
using System.ComponentModel;

namespace JLaraSystemLeng.Progresses.Dtos;

[Serializable]
public class CreateUpdateProgressDto
{
    [DisplayName("ProgressUserId")]
    public Guid UserId { get; set; }

    [DisplayName("ProgressPronunciationAccuracy")]
    public decimal? PronunciationAccuracy { get; set; }

    [DisplayName("ProgressProgressValue")]
    public decimal? ProgressValue { get; set; }
}