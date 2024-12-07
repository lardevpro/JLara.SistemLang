using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace JLaraSystemLeng.Progresses.Dtos;

[Serializable]
public class ProgressGetListInput : PagedAndSortedResultRequestDto
{
    [DisplayName("ProgressUserId")]
    public Guid? UserId { get; set; }

    [DisplayName("ProgressPronunciationAccuracy")]
    public decimal? PronunciationAccuracy { get; set; }

    [DisplayName("ProgressProgressValue")]
    public decimal? ProgressValue { get; set; }
}