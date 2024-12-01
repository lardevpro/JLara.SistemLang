using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JLaraSystemLeng.Sugesstions;
using JLaraSystemLeng.Sugesstions.Dtos;
using JLaraSystemLeng.Web.Pages.Sugesstions.Sugesstion.ViewModels;

namespace JLaraSystemLeng.Web.Pages.Sugesstions.Sugesstion;

public class CreateModalModel : JLaraSystemLengPageModel
{
    [BindProperty]
    public CreateEditSugesstionViewModel ViewModel { get; set; }

    private readonly ISugesstionAppService _service;

    public CreateModalModel(ISugesstionAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditSugesstionViewModel, CreateUpdateSugesstionDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}