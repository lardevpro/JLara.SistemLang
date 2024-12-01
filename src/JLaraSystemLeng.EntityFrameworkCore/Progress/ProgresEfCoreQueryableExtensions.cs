using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JLaraSystemLeng.Progress;

public static class ProgresEfCoreQueryableExtensions
{
    public static IQueryable<Progres> IncludeDetails(this IQueryable<Progres> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
