using System;

using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Sugesstions
{
    public class Sugesstion: FullAuditedAggregateRoot<Guid>
    {
       public Guid UserId { get; set; }
       public string? SugesstionText {  get; set; }
       public DateTime? SugesstionCreationDate { get; set; }

    protected Sugesstion()
    {
    }

    public Sugesstion(
        Guid id,
        Guid userId,
        string? sugesstionText,
        DateTime? sugesstionCreationDate
    ) : base(id)
    {
        UserId = userId;
        SugesstionText = sugesstionText;
        SugesstionCreationDate = sugesstionCreationDate;
    }
    }
}
