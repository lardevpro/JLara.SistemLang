using System;
using System.Linq;
using System.Threading.Tasks;
using JLaraSystemLeng.Permissions;
using JLaraSystemLeng.Exercise.Dtos;
using Volo.Abp.Application.Services;
using JLaraSystemLeng.Exercise;

namespace JLaraSystemLeng.Exercise;


public class ExerciseAppService : CrudAppService<Exercise, ExerciseDto, Guid, ExerciseGetListInput, CreateUpdateExerciseDto, CreateUpdateExerciseDto>,
    IExerciseAppService
{
    protected override string GetPolicyName { get; set; } = JLaraSystemLengPermissions.Exercise.Default;
    protected override string GetListPolicyName { get; set; } = JLaraSystemLengPermissions.Exercise.Default;
    protected override string CreatePolicyName { get; set; } = JLaraSystemLengPermissions.Exercise.Create;
    protected override string UpdatePolicyName { get; set; } = JLaraSystemLengPermissions.Exercise.Update;
    protected override string DeletePolicyName { get; set; } = JLaraSystemLengPermissions.Exercise.Delete;

    private readonly IExerciseRepository _repository;

    public ExerciseAppService(IExerciseRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Exercise>> CreateFilteredQueryAsync(ExerciseGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(input.UserId != null, x => x.UserId == input.UserId)
            .WhereIf(input.Phrase != null, x => x.Phrase == input.Phrase)
            .WhereIf(input.DifficultyLevel != null, x => x.DifficultyLevel == input.DifficultyLevel)
            .WhereIf(!input.FocusArea.IsNullOrWhiteSpace(), x => x.FocusArea.Contains(input.FocusArea))
            ;
    }
}
