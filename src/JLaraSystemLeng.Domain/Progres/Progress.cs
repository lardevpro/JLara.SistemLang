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
        public decimal? PronunciationAccuracy { get; set; }
        public string? Recommendation { get; set; }
        public string? DifficultyLevel {get; set; } 
    }
}
