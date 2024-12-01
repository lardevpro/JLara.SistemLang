using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.Permissions;
using JLaraSystemLeng.Sugesstions.Dtos;
using Volo.Abp.Application.Services;

namespace JLaraSystemLeng.Sugesstions;


public class SugesstionAppService : CrudAppService<Sugesstion, SugesstionDto, Guid, SugesstionGetListInput, CreateUpdateSugesstionDto, CreateUpdateSugesstionDto>,
    ISugesstionAppService
{
    protected override string GetPolicyName { get; set; } = JLaraSystemLengPermissions.Sugesstion.Default;
    protected override string GetListPolicyName { get; set; } = JLaraSystemLengPermissions.Sugesstion.Default;
    protected override string CreatePolicyName { get; set; } = JLaraSystemLengPermissions.Sugesstion.Create;
    protected override string UpdatePolicyName { get; set; } = JLaraSystemLengPermissions.Sugesstion.Update;
    protected override string DeletePolicyName { get; set; } = JLaraSystemLengPermissions.Sugesstion.Delete;

    private readonly ISugesstionRepository _repository;

    public SugesstionAppService(ISugesstionRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Sugesstion>> CreateFilteredQueryAsync(SugesstionGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(input.UserId != null, x => x.UserId == input.UserId)
            .WhereIf(input.SugesstionText != null, x => x.SugesstionText == input.SugesstionText)
            .WhereIf(input.SugesstionCreationDate != null, x => x.SugesstionCreationDate == input.SugesstionCreationDate)
            ;
    }
}
