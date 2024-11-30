using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Exercise
{
    public class Exercises : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }
        public IdentityUser User { get; set; }
        public int? Phrase { get; set; }
        public string? DifficultyLevel { get; set; }
        public string FocusArea { get; set; }
    }
}
