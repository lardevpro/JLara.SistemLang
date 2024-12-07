using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Progresses
{
    public class Progress : FullAuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }
        public decimal? PronunciationAccuracy { get; set; }
        public decimal? ProgressValue { get; set; }

        protected Progress()
        {
        }

        public Progress(
            Guid id,
            Guid userId,
            decimal? pronunciationAccuracy,
            decimal? progressValue
        ) : base(id)
        {
            UserId = userId;
            PronunciationAccuracy = pronunciationAccuracy;
            ProgressValue = progressValue;
        }
    }
}
