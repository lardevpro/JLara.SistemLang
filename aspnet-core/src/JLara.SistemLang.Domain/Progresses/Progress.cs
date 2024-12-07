using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Progresses
{
    public class Progress: FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }
        public DateTime? PracticeDate { get; set; }
        public decimal? PronunciationAccuracy { get; set; }
        public string? Recommendation { get; set; }
        public string? DifficultyLevel {get; set; } 

    protected Progress()
    {
    }

    public Progress(
        Guid id,
        Guid userId,
        DateTime? practiceDate,
        decimal? pronunciationAccuracy,
        string? recommendation,
        string? difficultyLevel
    ) : base(id)
    {
        UserId = userId;
        PracticeDate = practiceDate;
        PronunciationAccuracy = pronunciationAccuracy;
        Recommendation = recommendation;
        DifficultyLevel = difficultyLevel;
    }
    }
}
