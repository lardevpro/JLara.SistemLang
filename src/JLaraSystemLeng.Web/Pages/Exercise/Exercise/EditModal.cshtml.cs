using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JLaraSystemLeng.Exercise;
using JLaraSystemLeng.Exercise.Dtos;
using JLaraSystemLeng.Web.Pages.Exercise.Exercise.ViewModels;

namespace JLaraSystemLeng.Web.Pages.Exercise.Exercise;

public class EditModalModel : JLaraSystemLengPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditExerciseViewModel ViewModel { get; set; }

    private readonly IExerciseAppService _service;

    public EditModalModel(IExerciseAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<ExerciseDto, CreateEditExerciseViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditExerciseViewModel, CreateUpdateExerciseDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}