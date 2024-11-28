using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Progress
{
    public class Progres: FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }
        public IdentityUser User { get; set; }
        public DateTime? PracticeDate { get; set; }
        public string? TranscriptionOrigin { get; set; }
        public decimal? PrecisiosPronunciation { get; set; }
        public string? Recommendation { get; set; }
    }
}
