using System;
using Volo.Abp.Application.Dtos;

namespace JLaraSystemLeng.Progresses.Dtos;

[Serializable]
public class ProgressDto : FullAuditedEntityDto<Guid>
{
    public Guid UserId { get; set; }

    public decimal? PronunciationAccuracy { get; set; }

    public decimal? ProgressValue { get; set; }
}