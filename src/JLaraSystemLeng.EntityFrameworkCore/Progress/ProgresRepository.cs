using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace JLaraSystemLeng.Progress;

public class ProgresRepository : EfCoreRepository<JLaraSystemLengDbContext, Progres, Guid>, IProgresRepository
{
    public ProgresRepository(IDbContextProvider<JLaraSystemLengDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Progres>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}