using System;
using System.ComponentModel.DataAnnotations;

namespace JLaraSystemLeng.Web.Pages.Sugesstions.Sugesstion.ViewModels;

public class CreateEditSugesstionViewModel
{
    [Display(Name = "SugesstionUserId")]
    public Guid UserId { get; set; }

    [Display(Name = "SugesstionSugesstionText")]
    public string? SugesstionText { get; set; }

    [Display(Name = "SugesstionSugesstionCreationDate")]
    public DateTime? SugesstionCreationDate { get; set; }
}
