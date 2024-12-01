using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.Permissions;
using JLaraSystemLeng.Progress.Dtos;
using Volo.Abp.Application.Services;

namespace JLaraSystemLeng.Progress;


public class ProgresAppService : CrudAppService<Progres, ProgresDto, Guid, ProgresGetListInput, CreateUpdateProgresDto, CreateUpdateProgresDto>,
    IProgresAppService
{
    protected override string GetPolicyName { get; set; } = JLaraSystemLengPermissions.Progres.Default;
    protected override string GetListPolicyName { get; set; } = JLaraSystemLengPermissions.Progres.Default;
    protected override string CreatePolicyName { get; set; } = JLaraSystemLengPermissions.Progres.Create;
    protected override string UpdatePolicyName { get; set; } = JLaraSystemLengPermissions.Progres.Update;
    protected override string DeletePolicyName { get; set; } = JLaraSystemLengPermissions.Progres.Delete;

    private readonly IProgresRepository _repository;

    public ProgresAppService(IProgresRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Progres>> CreateFilteredQueryAsync(ProgresGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(input.UserId != null, x => x.UserId == input.UserId)
            .WhereIf(input.PracticeDate != null, x => x.PracticeDate == input.PracticeDate)
            .WhereIf(input.PronunciationAccuracy != null, x => x.PronunciationAccuracy == input.PronunciationAccuracy)
            .WhereIf(input.Recommendation != null, x => x.Recommendation == input.Recommendation)
            .WhereIf(input.DifficultyLevel != null, x => x.DifficultyLevel == input.DifficultyLevel)
            ;
    }
}
