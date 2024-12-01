using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace JLaraSystemLeng.Sugesstions;

public class SugesstionRepository : EfCoreRepository<JLaraSystemLengDbContext, Sugesstion, Guid>, ISugesstionRepository
{
    public SugesstionRepository(IDbContextProvider<JLaraSystemLengDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Sugesstion>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}