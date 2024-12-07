using System;
using System.Linq;
using System.Threading.Tasks;
using JLara.SistemLang.Permissions;
using JLaraSystemLeng.Progresses.Dtos;
using Volo.Abp.Application.Services;

namespace JLaraSystemLeng.Progresses;


public class ProgressAppService : CrudAppService<Progress, ProgressDto, Guid, ProgressGetListInput, CreateUpdateProgressDto, CreateUpdateProgressDto>,
    IProgressAppService
{
    protected override string GetPolicyName { get; set; } = SistemLangPermissions.Progress.Default;
    protected override string GetListPolicyName { get; set; } = SistemLangPermissions.Progress.Default;
    protected override string CreatePolicyName { get; set; } = SistemLangPermissions.Progress.Create;
    protected override string UpdatePolicyName { get; set; } = SistemLangPermissions.Progress.Update;
    protected override string DeletePolicyName { get; set; } = SistemLangPermissions.Progress.Delete;

    private readonly IProgressRepository _repository;

    public ProgressAppService(IProgressRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Progress>> CreateFilteredQueryAsync(ProgressGetListInput input)
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
