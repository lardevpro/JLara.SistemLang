using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JLaraSystemLeng.Progress;
using JLaraSystemLeng.Progress.Dtos;
using JLaraSystemLeng.Web.Pages.Progress.Progres.ViewModels;

namespace JLaraSystemLeng.Web.Pages.Progress.Progres;

public class EditModalModel : JLaraSystemLengPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditProgresViewModel ViewModel { get; set; }

    private readonly IProgresAppService _service;

    public EditModalModel(IProgresAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<ProgresDto, CreateEditProgresViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditProgresViewModel, CreateUpdateProgresDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}