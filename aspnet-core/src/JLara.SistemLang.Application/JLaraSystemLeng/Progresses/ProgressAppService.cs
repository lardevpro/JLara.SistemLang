using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.Progresses.Dtos;
using Volo.Abp.Application.Services;

namespace JLaraSystemLeng.Progresses;


public class ProgressAppService : CrudAppService<Progress, ProgressDto, Guid, ProgressGetListInput, CreateUpdateProgressDto, CreateUpdateProgressDto>,
    IProgressAppService
{

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
            .WhereIf(input.PronunciationAccuracy != null, x => x.PronunciationAccuracy == input.PronunciationAccuracy)
            .WhereIf(input.ProgressValue != null, x => x.ProgressValue == input.ProgressValue)
            ;
    }
}
