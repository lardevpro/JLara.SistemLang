using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Exercise
{
    public class Exercise : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }
        public int? Phrase { get; set; }
        public string? DifficultyLevel { get; set; }
        public string FocusArea { get; set; }

    protected Exercise()
    {
    }

    public Exercise(
        Guid id,
        Guid userId,
        int? phrase,
        string? difficultyLevel,
        string focusArea
    ) : base(id)
    {
        UserId = userId;
        Phrase = phrase;
        DifficultyLevel = difficultyLevel;
        FocusArea = focusArea;
    }
    }
}