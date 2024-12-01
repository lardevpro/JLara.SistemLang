using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JLaraSystemLeng.Progress;
using JLaraSystemLeng.Progress.Dtos;
using JLaraSystemLeng.Web.Pages.Progress.Progres.ViewModels;

namespace JLaraSystemLeng.Web.Pages.Progress.Progres;

public class CreateModalModel : JLaraSystemLengPageModel
{
    [BindProperty]
    public CreateEditProgresViewModel ViewModel { get; set; }

    private readonly IProgresAppService _service;

    public CreateModalModel(IProgresAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditProgresViewModel, CreateUpdateProgresDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}