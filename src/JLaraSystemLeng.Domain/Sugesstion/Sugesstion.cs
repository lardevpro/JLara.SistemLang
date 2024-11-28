using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace JLaraSystemLeng.Sugesstions
{
    public class Sugesstion: FullAuditedAggregateRoot<Guid>
    {
       public Guid UserId { get; set; }
       public IdentityUser User { get; set; }
       public string? SugesstionText {  get; set; }
       public DateTime? DateSugesstion { get; set; }
    }
}
