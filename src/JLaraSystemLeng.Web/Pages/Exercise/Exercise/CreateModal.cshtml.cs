using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JLaraSystemLeng.Exercise;
using JLaraSystemLeng.Exercise.Dtos;
using JLaraSystemLeng.Web.Pages.Exercise.Exercise.ViewModels;

namespace JLaraSystemLeng.Web.Pages.Exercise.Exercise;

public class CreateModalModel : JLaraSystemLengPageModel
{
    [BindProperty]
    public CreateEditExerciseViewModel ViewModel { get; set; }

    private readonly IExerciseAppService _service;

    public CreateModalModel(IExerciseAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditExerciseViewModel, CreateUpdateExerciseDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}