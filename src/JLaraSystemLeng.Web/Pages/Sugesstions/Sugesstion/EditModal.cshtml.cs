using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JLaraSystemLeng.Sugesstions;
using JLaraSystemLeng.Sugesstions.Dtos;
using JLaraSystemLeng.Web.Pages.Sugesstions.Sugesstion.ViewModels;

namespace JLaraSystemLeng.Web.Pages.Sugesstions.Sugesstion;

public class EditModalModel : JLaraSystemLengPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditSugesstionViewModel ViewModel { get; set; }

    private readonly ISugesstionAppService _service;

    public EditModalModel(ISugesstionAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<SugesstionDto, CreateEditSugesstionViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditSugesstionViewModel, CreateUpdateSugesstionDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}