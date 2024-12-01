using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.EntityFrameworkCore;
using JLaraSystemLeng.Exercise;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace JLaraSystemLeng.Exercise;

public class ExerciseRepository : EfCoreRepository<JLaraSystemLengDbContext, Exercise, Guid>, IExerciseRepository
{
    public ExerciseRepository(IDbContextProvider<JLaraSystemLengDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Exercise>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}